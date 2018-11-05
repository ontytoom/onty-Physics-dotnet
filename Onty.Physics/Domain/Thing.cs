using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

using Onty.LibMath.Vectors;
using Onty.LibMath.Util;

using Onty.Physics.Util;



namespace Onty.Physics.Domain
{

	public class Thing
	{
		// data
		[XmlAttribute]
		public int id;

		// this is the Radius
		[XmlElement( "Size" )]
		public double size;

		[XmlElement( "Location" )]
		public Location2d location;

		[XmlElement( "Velocity" )]
		public Velocity2d velocity;

		[XmlIgnore]
		public Vector2d       gravityNet;
		public List<Vector2d> gravityComponents;

		[XmlIgnore]
		public Color color;

		[XmlIgnore]
		public FieldState myField;

		private static Random r = new Random( (int)DateTime.Now.Ticks );
		private static int idNext = 0;               // to determine IDs


		// ctor
		public Thing()
		{
		}

		public Thing( FieldState field, Location2d location, Velocity2d velocity, double size )
		{
			this.id       = idNext++;
			this.myField  = field;
			this.size     = size;
			this.location = location;
			this.velocity = velocity;

			// random color
			color = Color.FromArgb( r.Next(256), r.Next(256), r.Next(256) );

		}


		// props

		public string Id
		{
			get
			{
				return id.ToString() + "@" + myField.time.ToString();
			}
		}

		[XmlElement("Color")]
		public ColorSrz ColorForSerialization
		{
			get
			{
				return new ColorSrz( this.color );
			}
			set
			{
				this.color = value;
			}
		}


		public double Mass
		{
			get
			{
				return size * size * Math.PI;
			}
			//set
			//{
			//	size = Math.Sqrt( value / Math.PI );
			//}
		}


		//goto new time
		public void GotoNewTime( decimal deltaT )
		{
			// calculate net gravity - used in calculations
			CalculateNetGravity();

			// adjust velocity
			Vector2d accel = gravityNet * (1 / Mass);
            velocity += accel * deltaT;

			// displace by
			location.DisplaceBy( velocity );

			//// check if location is outside of bounds
			//CheckBounds();

			// check if we are overlapping with any other Things
			CheckOverlap();

			// calculate net gravity - for display
			CalculateNetGravity();

		}//GotoNewTime


		public void CalculateNetGravity()
		{
			// look at each thing in the field:
			//   find unit vector in its direction
			//   find magnitude of gravity
			//   multiply
			// find sum of vectors from above and return it

			Vector2d net = new Vector2d();
			this.gravityComponents = new List<Vector2d>();

			foreach ( Thing t in myField.things )
			{
				if ( this == t )
					continue;

				Vector2d v = new Vector2d();
				v.i = (t.location.x - this.location.x);
				v.j = (t.location.y - this.location.y);
				double dist = v.Length();
				v.Normalize();

				double coeff = GlobalConfig.gravityCoeff * ( this.Mass * t.Mass) / (dist * dist);

				v = v * coeff;

				this.gravityComponents.Add( v );

				net += v;
			}

			gravityNet = net;
		}


		public void CheckOverlap()
		{
			List<Thing> list = new List<Thing>();

			foreach ( Thing t in myField.things )
			{
				if ( t == this )
					continue;

				double dist = this.CalculateSpaceBetween( t );
				if ( dist < 0 )
					list.Add( t );
			}

			if ( list.Count > 0 )
			{
				list.Add( this );
				myField.ScheduleCombine( list );
			}

		}


		public decimal CalculateOptimalDeltaT()
		{
			if ( velocity.Length() == 0 )
				return Decimal.MaxValue;

			return (decimal)(size / velocity.Length());
		}


		public double CalculateSpaceBetween( Thing t2 )
		{
			double dist = Location2d.Distance( location, t2.location );

			dist -= size;
			dist -= t2.size;

			return dist;
		}


		public double CalculateSpaceBetween( Location2d location2, double size2 )
		{
			double dist = Location2d.Distance( this.location, location2 );

			dist -= size;
			dist -= size2;

			return dist;
		}


		//private void CheckBounds()
		//{
		//	double left = size;
		//	double right = myField.size.Width - size;
		//	double top = size;
		//	double bottom = myField.size.Height - size;

		//	// x
		//	if ( location.x < left )
		//	{
		//		location.x = left - (location.x-left);
		//		velocity.i = -velocity.i;
		//	}
		//	else if ( location.x >= right )
		//	{
		//		location.x = (right) - (location.x-right);
		//		velocity.i = -velocity.i;
		//	}

		//	// y
		//	if ( location.y < top )
		//	{
		//		location.y = top - (location.y-top);
		//		velocity.j = -velocity.j;
		//	}
		//	else if ( location.y >= (bottom) )
		//	{
		//		location.y = (bottom) - (location.y-bottom);
		//		velocity.j = -velocity.j;
		//	}

		//}


		public Thing MakeCopy()
		{
			Thing copy = new Thing();

			copy.id       = this.id;
			copy.location = new Location2d( this.location );
			copy.velocity = new Velocity2d( this.velocity );
			copy.size     = this.size;
			copy.color    = Color.FromArgb( this.color.ToArgb() );

			return copy;
		}


		public static Thing Combine( List<Thing> list )
		{
			if ( list.Count < 2 )
				throw new PhysicsException( "Combine called with <2 items. This does not make sense." );

			AveragerUtil massA = new AveragerUtil();

			AveragerUtil colorR = new AveragerUtil();
			AveragerUtil colorG = new AveragerUtil();
			AveragerUtil colorB = new AveragerUtil();

			AveragerUtil locXM = new AveragerUtil();
			AveragerUtil locYM = new AveragerUtil();

			AveragerUtil velIM = new AveragerUtil();
			AveragerUtil velJM = new AveragerUtil();


			foreach ( Thing t in list )
			{
				massA.AddMeasurement( t.Mass );

				colorR.AddMeasurement( t.color.R );
				colorG.AddMeasurement( t.color.G );
				colorB.AddMeasurement( t.color.B );

				locXM.AddMeasurement( t.location.x * t.Mass );
				locYM.AddMeasurement( t.location.y * t.Mass );

				velIM.AddMeasurement( t.velocity.i * t.Mass );
				velJM.AddMeasurement( t.velocity.j * t.Mass );
			}

			// mass
			double size = Math.Sqrt( massA.Sum / Math.PI );

			// color
			Color color = Color.FromArgb( (int)colorR.Average, (int)colorG.Average, (int)colorB.Average );

			// location
			Location2d loc = new Location2d( locXM.Sum / massA.Sum, locYM.Sum / massA.Sum );

			// velocity
			Velocity2d vel = new Velocity2d( velIM.Sum / massA.Sum, velJM.Sum / massA.Sum );

			return new Thing( list[0].myField, loc, vel, size );
		}



	}//class Thing


}//ns

