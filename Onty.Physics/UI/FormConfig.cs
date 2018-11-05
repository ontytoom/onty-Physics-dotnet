using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Onty.Physics.Util;
using Onty.Physics.Domain;


namespace Onty.Physics.UI
{

	public partial class FormConfig : Form
	{
		// data
		private Field field;

		private int    nrThings;
		private double sizeMin, sizeMax;
		private double kGravity;

		private decimal timeInc;
		private double timeSleep;

		private float viewportTop;
		private float viewportBottom;
		private float viewportLeft;
		private float viewportRight;

		private float viewportZoom;
		private float viewportShift;

		//private bool logToStdout;


		// ctor
		public FormConfig( Field field )
		{
			InitializeComponent();

			this.field = field;

			// init
			textNrThings.Text = GlobalConfig.NrThings.ToString();

			textSizeMax.Text = GlobalConfig.sizeMax.ToString();
			textSizeMin.Text = GlobalConfig.sizeMin.ToString();

			textViewportTop   .Text = GlobalConfig.viewport.Top   .ToString();
			textViewportBottom.Text = GlobalConfig.viewport.Bottom.ToString();
			textViewportLeft  .Text = GlobalConfig.viewport.Left  .ToString();
			textViewportRight .Text = GlobalConfig.viewport.Right .ToString();

			textViewportZoom .Text = GlobalConfig.viewportZoomPercentage .ToString();
			textViewportShift.Text = GlobalConfig.viewportShiftPercentage.ToString();

			textKGravity.Text = GlobalConfig.gravityCoeff.ToString();

			textTimeIncrement.Text = GlobalConfig.timeIncrement.ToString();

			textTimeSleepIter.Text = GlobalConfig.timeSleepBetweenIterations.ToString();

			checkLogStdout.Checked = GlobalConfig.LogToStdout;
		}


		private void buttonSave_Click( object sender, EventArgs e )
		{
			FromUiToLocalVars();

			GlobalConfig.NrThings     = this.nrThings;

			GlobalConfig.sizeMin = this.sizeMin;
			GlobalConfig.sizeMax = this.sizeMax;

			GlobalConfig.gravityCoeff = this.kGravity;

			GlobalConfig.timeIncrement = this.timeInc;
			GlobalConfig.timeSleepBetweenIterations = this.timeSleep;

			GlobalConfig.LogToStdout = checkLogStdout.Checked;

			GlobalConfig.viewport = new RectangleF( viewportLeft, viewportTop, viewportRight-viewportLeft, viewportBottom-viewportTop );

			GlobalConfig.viewportZoomPercentage  = viewportZoom;
			GlobalConfig.viewportShiftPercentage = viewportShift;

			this.Close();
        }


		private void buttonCxl_Click( object sender, EventArgs e )
		{
			this.Close();
		}


		private void linkVerify_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			FromUiToLocalVars();

			DisplayFillFactor();
		}


		private void textALL_Enter( object sender, EventArgs e )
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}


		private void linkViewportAuto_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			RectangleF rect = ViewportUtil.Fit( field.CurrentState );

			textViewportLeft  .Text = rect.Left  .ToString();
			textViewportRight .Text = rect.Right .ToString();
			textViewportTop   .Text = rect.Top   .ToString();
			textViewportBottom.Text = rect.Bottom.ToString();
		}



		// prv

		private void FromUiToLocalVars()
		{
			// viewport
			float? viewportTop;
			float? viewportBottom;
			float? viewportLeft;
			float? viewportRight;

			viewportTop    = ParseOneFloatFromTextbox( textViewportTop,    "Viewport Top" );
			viewportBottom = ParseOneFloatFromTextbox( textViewportBottom, "Viewport Bottom" );
			viewportLeft   = ParseOneFloatFromTextbox( textViewportLeft,   "Viewport Left" );
			viewportRight  = ParseOneFloatFromTextbox( textViewportRight,  "Viewport Right" );

			if ( viewportTop == null )
				return;
			else
				this.viewportTop = (float)viewportTop;

			if ( viewportBottom == null )
				return;
			else
				this.viewportBottom = (float)viewportBottom;

			if ( viewportLeft == null )
				return;
			else
				this.viewportLeft = (float)viewportLeft;

			if ( viewportRight == null )
				return;
			else
				this.viewportRight = (float)viewportRight;

			// viewport zoom
			float? viewportZoom = ParseOneFloatFromTextbox( textViewportZoom, "Viewport Zoom" );

			if ( viewportZoom == null )
				return;
			else
				this.viewportZoom = (float)viewportZoom;

			// viewport shift
			float? viewportShift = ParseOneFloatFromTextbox( textViewportShift, "Viewport Shift" );

			if ( viewportShift == null )
				return;
			else
				this.viewportShift = (float)viewportShift;

			// nr things
			int? nrThings = ParseOneIntFromTextbox( textNrThings, "Number of things" );

			if ( nrThings == null )
				return;
			else
				this.nrThings = (int)nrThings;

			// min size
			double? sizeMin = ParseOneDoubleFromTextbox( textSizeMin, "Min size" );

			if ( sizeMin == null )
				return;
			else
				this.sizeMin = (double)sizeMin;

			// max size
			double? sizeMax = ParseOneDoubleFromTextbox( textSizeMax, "Max size" );

			if ( sizeMax == null )
				return;
			else
				this.sizeMax = (double)sizeMax;

			// log to stdout?
			checkLogStdout.Checked = GlobalConfig.LogToStdout;

			// max size
			double? kGrav = ParseOneDoubleFromTextbox( textKGravity, "Gravity Coefficient" );

			if ( kGrav == null )
				return;
			else
				this.kGravity = (double)kGrav;

			// max size
			decimal? timeInc = ParseOneDecimalFromTextbox( textTimeIncrement, "Time Increment" );

			if ( timeInc == null )
				return;
			else
				this.timeInc = (decimal)timeInc;

			// max size
			double? timeSleep = ParseOneDoubleFromTextbox( textTimeSleepIter, "Time Sleep" );

			if ( timeSleep == null )
				return;
			else
				this.timeSleep = (double)timeSleep;
		}




		private void DisplayFillFactor()
		{
			if ( field == null )
			{
				MessageBox.Show( this, "Please make a field first" );
				return;
			}

			// display fill factor
			StringBuilder sb = new StringBuilder();

			double fillFactor = CalculateFillFactor( sizeMin, sizeMax, field.Viewport.Width, field.Viewport.Height, nrThings );
			sb.AppendLine( "Estimated fill factor = " + fillFactor.ToString( "0.00" ) );

			labelFillFactor.Text = sb.ToString();

		}


		private double CalculateFillFactor( double sizeMin, double sizeMax, double fieldWidth, double fieldHeight, double count )
		{
			// calc avg size
			double sizeAvg = Math.PI / 3.0 * (sizeMax * sizeMax * sizeMax - sizeMin * sizeMin * sizeMin) / (sizeMax - sizeMin);

			// calc field area
			double fieldArea = fieldWidth * fieldHeight;

			// factor
			double factor = sizeAvg * count / fieldArea;

			return factor;
		}


		private int? ParseOneIntFromTextbox( TextBox t, string name )
		{
			int result;

			try
			{
				result = Int32.Parse( t.Text );
				t.BackColor = default(Color);
			}
			catch ( Exception )
			{
				MessageBox.Show( this, "Cannot parse " + name );
				t.BackColor = Color.Orange;
				return null;
			}

			return result;
		}

		private double? ParseOneDoubleFromTextbox( TextBox t, string name )
		{
			double result;

			try
			{
				result = Double.Parse( t.Text );
				t.BackColor = default(Color);
			}
			catch ( Exception )
			{
				MessageBox.Show( this, "Cannot parse " + name );
				t.BackColor = Color.Orange;
				return null;
			}

			return result;
		}

		private float? ParseOneFloatFromTextbox( TextBox t, string name )
		{
			float result;

			try
			{
				result = float.Parse( t.Text );
				t.BackColor = default(Color);
			}
			catch ( Exception )
			{
				MessageBox.Show( this, "Cannot parse " + name );
				t.BackColor = Color.Orange;
				return null;
			}

			return result;
		}

		private decimal? ParseOneDecimalFromTextbox( TextBox t, string name )
		{
			decimal result;

			try
			{
				result = decimal.Parse( t.Text );
				t.BackColor = default(Color);
			}
			catch ( Exception )
			{
				MessageBox.Show( this, "Cannot parse " + name );
				t.BackColor = Color.Orange;
				return null;
			}

			return result;
		}

		//private <T>? ParseOneGenericFromTextbox( TextBox t, string name )
		//{
		//	decimal result;

		//	try
		//	{
		//		result = decimal.Parse( t.Text );
		//		t.BackColor = default(Color);
		//	}
		//	catch ( Exception )
		//	{
		//		MessageBox.Show( this, "Cannot parse " + name );
		//		t.BackColor = Color.Orange;
		//		return null;
		//	}

		//	return result;
		//}


	}

}//ns

