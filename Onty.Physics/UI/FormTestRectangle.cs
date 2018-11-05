using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Onty.Physics.UI
{

	public partial class FormTestRectangle : Form
	{
		private RectangleF rect;

		public FormTestRectangle()
		{
			InitializeComponent();

			rect = new RectangleF( 0, 0, 100, 100 );

			DebugPrintLn( rect.ToString() );
			PrintRect();
		}

		private void linkMul1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			float coeff;
			try
			{
				coeff = float.Parse( textMul1.Text );
			}
			catch(Exception ex)
			{
				MessageBox.Show( this, ex.Message );
				return;
			}

			rect.Inflate( coeff, coeff );

			DebugPrintLn( rect.ToString() );
			PrintRect();
		}

		private void linkMul2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			float coeff;
			try
			{
				coeff = float.Parse( textMul2.Text );
			}
			catch( Exception ex)
			{
				MessageBox.Show( this, ex.Message );
				return;
			}

			rect.Inflate( coeff * rect.Width, coeff * rect.Height );

			DebugPrintLn( rect.ToString() );
			PrintRect();
		}


		private void PrintRect()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat( "Left={0:0.###}", rect.Left );
			sb.AppendFormat( " Right={0:0.###}", rect.Right );
			sb.AppendFormat( " Top={0:0.###}", rect.Top );
			sb.AppendFormat( " Bottom={0:0.###}", rect.Bottom );
			sb.AppendLine();

			DebugPrintLn( sb.ToString() );
		}

		private void DebugPrintLn( string s )
		{
			textOut.AppendText( s );
			textOut.AppendText( Environment.NewLine );
		}

	}

}//ns
