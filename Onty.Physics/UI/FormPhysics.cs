using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Onty.Physics.Domain;
using Onty.Physics.Util;


namespace Onty.Physics.UI
{

	public partial class FormPhysics : Form
	{

		// data
		private Bitmap bitmap;
		private Field  field;
		private bool   performSliderEvents = true;


		// ctor
		public FormPhysics()
		{
			InitializeComponent();

			SetStatus ( "need init" );
			SetStatus2( "need init" );

			// init title bar
			string title = Application.ProductName + " " + Application.ProductVersion;
			this.Text = title;
		}


		#region Menu

		private void toolStripMenuItem_About2_Click( object sender, EventArgs e )
		{
			UI.FormAbout formAbout = new UI.FormAbout();
			formAbout.StartPosition = FormStartPosition.CenterParent;
			formAbout.ShowDialog( this );
		}


		private void toolStripMenuItem_Quit_Click( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void toolStripMenuItem_Open_Click( object sender, EventArgs e )
		{
			//// determine filename and path
			//OpenFileDialog openDialog = new OpenFileDialog();

			//openDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			//openDialog.FilterIndex = 0;
			//openDialog.DefaultExt = ".xml";

			//DialogResult result = openDialog.ShowDialog( this );
			//string fileName = openDialog.FileName;

			//if ( result == DialogResult.Cancel )
			//	return;

			//this.field = FieldReaderWriter.ConvertXmlToField( fileName );

			////UI.FormTextbox formTB = new UI.FormTextbox( xml );
			////formTB.ShowDialog( this );

			//// draw field
			//RepaintField();

		}

		private void toolStripMenuItem_SaveAs_Click( object sender, EventArgs e )
		{
			//if (this.field == null)
			//{
			//	MessageBox.Show( "Please init field first." );
			//	return;
			//}

			//// determine filename and path
			//SaveFileDialog saveDialog = new SaveFileDialog();

			//saveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			//saveDialog.FilterIndex = 0;
			//saveDialog.DefaultExt = ".xml";

			//DialogResult result = saveDialog.ShowDialog( this );
			//string fileName = saveDialog.FileName;

			//if (result == DialogResult.Cancel)
			//	return;

			////Logger.AddMessage( "dialog result=" + result );

			//string xml = FieldReaderWriter.ConvertFieldToXml( field, fileName );

			//UI.FormTextbox formTB = new UI.FormTextbox( xml );
			//formTB.ShowDialog( this );
		}


		private void toolStripMenuItem_SaveAs2_Click( object sender, EventArgs e )
		{
			if ( this.field == null )
			{
				MessageBox.Show( "Please init field first." );
				return;
			}

			// determine filename and path
			SaveFileDialog saveDialog = new SaveFileDialog();

			saveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			saveDialog.FilterIndex = 0;
			saveDialog.DefaultExt = ".xml";

			DialogResult result = saveDialog.ShowDialog( this );
			string fileName = saveDialog.FileName;

			if ( result == DialogResult.Cancel )
				return;

			FieldReaderWriter.ConvertFieldToXml2( field, fileName );
		}


		private void toolStripMenuItem_Config_Click( object sender, EventArgs e )
		{
			UI.FormConfig formConfig = new UI.FormConfig( field );
			formConfig.StartPosition = FormStartPosition.CenterParent;
			formConfig.ShowDialog( this );

			RepaintField();
		}


		private void toolStripMenuItem_ZoomIn_Click( object sender, EventArgs e )
		{
			ZoomIn();
		}

		private void toolStripMenuItem_ZoomOut_Click( object sender, EventArgs e )
		{
			ZoomOut();
		}


		private void toolStripMenuItem_TestRectangle_Click( object sender, EventArgs e )
		{
			FormTestRectangle formTestRect = new FormTestRectangle();
			formTestRect.ShowDialog( this );
		}


		#endregion Menu



		#region Buttons

		private void buttonInit_Click( object sender, EventArgs e )
		{
			// make bitmap
			Size size = pictureBox1.ClientSize;

			// init field
			//try
			//{
			this.field = new Field( GlobalConfig.NrThings );
			//}
			//catch ( Exception ex )
			//{
			//	MessageBox.Show( this, ex.Message );
			//	return;
			//}

			// draw field
			RepaintField();
			UpdateSlider();

			// debug
			DebugPrintLine( "size=" + pictureBox1.Size );
			DebugPrintLine( "Nr of things: " + this.field.things.Count );

			// set status
			SetStatus( "initialized" );
			SetStatus2( "initialized" );
		}


		private void buttonIncrTime_Click( object sender, EventArgs e )
		{
			if ( this.field == null || backgroundWorker1.IsBusy )
				return;

			Transition( UpdateMode.Interactive );
		}


		private void buttonRun_Click( object sender, EventArgs e )
		{
			if ( this.field == null || backgroundWorker1.IsBusy )
				return;

			backgroundWorker1.RunWorkerAsync();

			// set status
			SetStatus( "running" );

			trackBar1.Enabled = false;
		}


		private void buttonStop_Click( object sender, EventArgs e )
		{
			if ( this.field == null || !backgroundWorker1.IsBusy )
				return;

			// request background worker stop
			backgroundWorker1.CancelAsync();

			// set status
			SetStatus( "stopping..." );
		}


		private void buttonZoomIn_Click( object sender, EventArgs e )
		{
			ZoomIn();
		}

		private void buttonZoomOut_Click( object sender, EventArgs e )
		{
			ZoomOut();
		}


		#endregion


		// form closing

		private void FormPhysics_FormClosing( object sender, FormClosingEventArgs e )
		{
			DialogResult result = MessageBox.Show( 
				this, 
				"Please click OK to close the application, or Cancel to keep it open.",
				"Quit?",
				MessageBoxButtons.OKCancel 
				);

			if ( result == DialogResult.Cancel )
				e.Cancel = true;

		}


		private void FormPhysics_Resize( object sender, EventArgs e )
		{
			RepaintField();
		}


		private void UpdateSlider()
		{
			performSliderEvents = false;

			trackBar1.Maximum = field.States.Count - 1;
			trackBar1.Value = trackBar1.Maximum;

			performSliderEvents = true;
		}

		private void trackBar1_ValueChanged( object sender, EventArgs e )
		{
			if ( !performSliderEvents )
				return;

			int id = trackBar1.Value;

			field.RewindTo( id );

			RepaintField();
		}





		#region Bg Worker

		private void backgroundWorker1_DoWork( object sender, DoWorkEventArgs e )
		{
			int sleep = (int) (GlobalConfig.timeSleepBetweenIterations * 1000);

			while ( !backgroundWorker1.CancellationPending )
			{
				// make field transition to next time
				Transition( UpdateMode.Batch );

				// pause 
				System.Threading.Thread.Sleep( sleep );
			}

		}

		private void backgroundWorker1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			UpdateSlider();

			// set status
			SetStatus( "stopped: " + e.Cancelled + " " + e.Error );

			trackBar1.Enabled = true;
		}

		#endregion Bg Worker


		private void Transition( UpdateMode mode )
		{
			// make field transition to next time
			field.GotoNewTime();

			// repaint field
			RepaintField();

			if ( mode == UpdateMode.Interactive )
				UpdateSlider();
		}


		private void RepaintField()
		{
			if ( this.field == null )
				return;

			// redisplay field
			this.bitmap = field.Draw( pictureBox1.ClientRectangle.Size );

			// if Draw returned null, client rectangle has 0 size, and we cannot paint on it.
			if ( this.bitmap == null )
				return;

			decimal time = field.time;

			pictureBox1.Image = this.bitmap;

			SetStatus2( "Time = " + time + " (" + field.States.Count + " states)" );
		}


		private void ZoomIn()
		{
			ViewportUtil.ZoomIn();
			RepaintField();
		}

		private void ZoomOut()
		{
			ViewportUtil.ZoomOut();
			RepaintField();
		}



		#region Debug and Status

		private void linkDebug_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( this.field == null )
			{
				DebugPrintLine( "Please init first" );
				return;
			}

			DebugPrintLine( "Time: " + field.CurrentState.time );
			DebugPrintLine( "Nr of things: " + field.CurrentState.things.Count );
		}


		private void linkDebug2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( this.field == null )
			{
				DebugPrintLine( "Please init first" );
				return;
			}

			foreach ( Thing a in field.CurrentState.things )
			{
				if ( a != field.CurrentState.things[0] )
					DebugPrintLine();

				DebugPrintLine( "Thing " + a.Id + ":" );
				DebugPrintLine( " location: " + a.location );
				DebugPrintLine( " velocity: " + a.velocity );
				DebugPrintLine( " size: " + a.size.ToString( "0.000" ) );
				DebugPrintLine( " gravity : " + a.gravityNet );
				if ( a.gravityComponents != null )
					DebugPrintLine( " gravity components count: " + a.gravityComponents.Count );
			}
		}


		private void linkDebugClear_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			textDebug.Clear();
		}


		private void linkViewportUp_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			ViewportUtil.Shift( 0, GlobalConfig.viewport.Height * GlobalConfig.viewportShiftPercentage );
			RepaintField();
		}

		private void linkViewportDown_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			ViewportUtil.Shift( 0, -GlobalConfig.viewport.Height * GlobalConfig.viewportShiftPercentage );
			RepaintField();
		}

		private void linkViewportLeft_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			ViewportUtil.Shift( GlobalConfig.viewport.Height * GlobalConfig.viewportShiftPercentage, 0 );
			RepaintField();
		}

		private void linkViewportRight_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			ViewportUtil.Shift( -GlobalConfig.viewport.Height * GlobalConfig.viewportShiftPercentage, 0 );
			RepaintField();
		}


		// status

		private delegate void SetStatusDelegate( string status );
		private delegate void SetStatus2Delegate( string status );

		private void SetStatus( string status )
		{
			if ( labelStatus.InvokeRequired )
			{
				SetStatusDelegate d = new SetStatusDelegate( SetStatusReal );
				labelStatus.Invoke( d, new object[] { status } );
			}
			else
				SetStatusReal( status );
		}

		private void SetStatus2( string status )
		{
			if ( labelStatus.InvokeRequired )
			{
				SetStatusDelegate d = new SetStatusDelegate( SetStatus2Real );
				labelStatus.Invoke( d, new object[] { status } );
			}
			else
				SetStatus2Real( status );
		}

		private void SetStatusReal( string status )
		{
			labelStatus.Text = status;
		}

		private void SetStatus2Real( string status )
		{
			labelStatus2.Text = status;
		}


		// for debugging
		public void DebugPrintLine( string s )
		{
			textDebug.AppendText( s );
			textDebug.AppendText( Environment.NewLine );
		}

		public void DebugPrintLine()
		{
			textDebug.AppendText( Environment.NewLine );
		}


		#endregion Debug and Status





		public enum UpdateMode
		{
			Interactive,
			Batch
		}


		private void FormPhysics_KeyPress( object sender, KeyPressEventArgs e )
		{
			//DebugPrintLine( "IsInputKey " + e.IsInputKey );
			//DebugPrintLine( "KeyCode" + e.KeyCode );
			//DebugPrintLine( "KeyData" + e.KeyData );
			//DebugPrintLine( "KeyValue" + e.KeyValue );
			DebugPrintLine( "Handled" + e.Handled );
			DebugPrintLine( "KeyChar" + e.KeyChar );


			if ( e.KeyChar == '+' )
				ZoomIn();
			else if ( e.KeyChar == '+' )
				ZoomOut();

		}

		private void pictureBox1_PreviewKeyDown( object sender, PreviewKeyDownEventArgs e )
		{
			DebugPrintLine( "pictureBox1_PreviewKeyDown" );

		}

	}

}//ns

