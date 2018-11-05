using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Onty.Physics.Util
{

	public class CoordinatesConverter
	{
		private Size screen;
		private RectangleF viewport;

		public CoordinatesConverter( Size screen, RectangleF viewport )
		{
			this.screen = screen;
			this.viewport = viewport;
		}

		public PointF ConvertPoint( PointF coordsWorld )
		{
			PointF coordsScreen = new PointF();

			coordsScreen.X = (coordsWorld.X - viewport.Left) / viewport.Width * screen.Width;
			coordsScreen.Y = (coordsWorld.Y - viewport.Top) / viewport.Height * screen.Height;

			return coordsScreen;
		}

		public PointF ConvertPoint( double coordsWorldX, double coordsWorldY )
		{
			PointF coordsScreen = new PointF();

			coordsScreen.X = (float)((coordsWorldX - viewport.Left) / viewport.Width * screen.Width);
			coordsScreen.Y = (float)((coordsWorldY - viewport.Top) / viewport.Height * screen.Height);

			return coordsScreen;
		}

		public float ConvertDistanceHorizontal( float distWorld )
		{
			float distScreen;
			distScreen = distWorld / viewport.Width * screen.Width;
			return distScreen;
		}

		public float ConvertDistanceVertical( float distWorld )
		{
			float distScreen;
			distScreen = distWorld / viewport.Height * screen.Height;
			return distScreen;
		}

	}
	
}//ns

