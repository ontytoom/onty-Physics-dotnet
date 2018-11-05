using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Onty.Physics.Domain;


namespace Onty.Physics.Util
{

	public static class ViewportUtil
	{

		public static void ZoomIn()
		{
			float factor = ( 1 - ( 1 / (1 + 2 * GlobalConfig.viewportZoomPercentage)) ) / 2;
			float factorHor = - GlobalConfig.viewport.Width  * (factor);
			float factorVer = - GlobalConfig.viewport.Height * (factor);

			GlobalConfig.viewport.Inflate( factorHor, factorVer );
		}

		public static void ZoomOut()
		{
			float factorHor = GlobalConfig.viewport.Width  * GlobalConfig.viewportZoomPercentage;
			float factorVer = GlobalConfig.viewport.Height * GlobalConfig.viewportZoomPercentage;

			GlobalConfig.viewport.Inflate( factorHor, factorVer );
		}

		public static void Shift( float shiftHor, float shiftVert )
		{
			GlobalConfig.viewport.Offset( shiftHor, shiftVert );
		}



		public static RectangleF Fit( FieldState fieldState )
		{

			float viewportTop    = float.MaxValue;
			float viewportBottom = float.MinValue;
			float viewportLeft   = float.MaxValue;
			float viewportRight  = float.MinValue;

			foreach ( Thing t in fieldState.things )
			{
				float left   = (float)(t.location.x - t.size);
				float right  = (float)(t.location.x + t.size);
				float top    = (float)(t.location.y - t.size);
				float bottom = (float)(t.location.y + t.size);


				if ( left   < viewportLeft )	viewportLeft   = left;
				if ( right  > viewportRight )	viewportRight  = right;
				if ( top    < viewportTop )		viewportTop    = top;
				if ( bottom > viewportBottom )	viewportBottom = bottom;
			}

			RectangleF rect = new RectangleF( viewportLeft, viewportTop, viewportRight - viewportLeft, viewportBottom - viewportTop );
			return rect;
		}

	}


}//ns
