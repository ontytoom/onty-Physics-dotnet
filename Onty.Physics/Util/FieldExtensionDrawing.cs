using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using Onty.LibMath.Vectors;

using Onty.Physics.Domain;


namespace Onty.Physics.Util
{

	public static class FieldExtensionDrawing
	{
		
		public static Bitmap Draw( this Field field, Size display, FieldState fieldState = null )
		{
			if ( display.Width <= 0 || display.Height <= 0 )
				return null;

			Bitmap bitmap = new Bitmap( display.Width, display.Height );

			Graphics g = Graphics.FromImage( bitmap );

			CoordinatesConverter conv = new CoordinatesConverter( display, field.Viewport );

			if ( fieldState == null )
				fieldState = field.CurrentState;

			// draw border
			int width  = display.Width;
			int height = display.Height;

			g.DrawLine( Pens.Aqua, 0, 0, width - 1, 0 );
			g.DrawLine( Pens.Aqua, width-1,0, width - 1, height-1 );
			g.DrawLine( Pens.Aqua, width-1, height-1, 0, height-1 );
			g.DrawLine( Pens.Aqua, 0, height - 1, 0, 0 );


			// paint all things

			foreach ( Thing t in fieldState.things )
			{
				// Draw a disc with center at its location, and radius its size, and color its color
				PointF p1 = new PointF();
				PointF p2 = new PointF();
				float w, h;

				p1.X = (float)(t.location.x - t.size);
				p1.Y = (float)(t.location.y - t.size);

				w = (float)(t.size * 2);
				h = (float)(t.size * 2);

				PointF p1s = conv.ConvertPoint( p1 );
				float ws = conv.ConvertDistanceHorizontal( w );
				float hs = conv.ConvertDistanceVertical( h );

				Brush b = new SolidBrush( t.color );

				g.FillEllipse( b, p1s.X, p1s.Y, ws, hs );

				// draw gravity vector
				if ( t.gravityNet != null )
				{
					p1 = new PointF();
					p2 = new PointF();

					p1 = conv.ConvertPoint( (float)t.location.x, (float)t.location.y );
					p2 = conv.ConvertPoint( t.location.x + t.gravityNet.i, t.location.y + t.gravityNet.j );

					g.DrawLine( Pens.White, p1, p2 );
				}

				// draw gravity component vectors
				if ( t.gravityComponents != null )
				{
					foreach ( Vector2d v in t.gravityComponents )
					{
						p1 = new PointF();
						p2 = new PointF();

						p1 = conv.ConvertPoint( (float)t.location.x, (float)t.location.y );
						p2 = conv.ConvertPoint( t.location.x + v.i, t.location.y + v.j );

						g.DrawLine( Pens.Aquamarine, p1, p2 );
					}
				}

				//// draw velocity vector
				//if ( a.velocity != null )
				//{
				//	x = (float)(a.location.x);
				//	y = (float)(a.location.y);
				//	g.DrawLine( Pens.Yellow, x, y, x + (float)a.velocity.i, y + (float)a.velocity.j );
				//}
			}

			return bitmap;
		}



	}

}//ns

