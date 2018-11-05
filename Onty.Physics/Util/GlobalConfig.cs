using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;


namespace Onty.Physics.Util
{

	public static class GlobalConfig
	{

		public static bool LogToStdout = true;

		public static int NrThings = 4;

		public static double velocityMax = 4.0;

		public static double gravityCoeff = 0.5;

		public static double sizeMax = 4.0;
		public static double sizeMin = 2.0;

		public static decimal timeIncrement = 0.1M;
		public static double  timeSleepBetweenIterations = 0.2;

		public static RectangleF viewport = new RectangleF( 0, 0, 100.0f, 100.0f );
		public static float      viewportZoomPercentage = 0.2f;
		public static float      viewportShiftPercentage = 0.1f;
	}

}//ns

