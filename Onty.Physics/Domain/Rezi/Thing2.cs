using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

using Onty.LibMath.Vectors;
using Onty.LibMath.Util;

using Onty.Physics.Util;



namespace Onty.Physics.Domain.Rezi
{

	public class Thing2
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
		public Vector2d       forceNet;
		public List<Vector2d> forceComponents;

		[XmlIgnore]
		public List<Rezinochka> rezinochki;

		[XmlIgnore]
		public Color color;

		[XmlIgnore]
		public Field2 myField;

		private static Random r = new Random( (int)DateTime.Now.Ticks );
		private static int idNext = 0;               // to determine IDs


		// ctor
		public Thing2()
		{
		}

		public Thing2( Field2 field, Location2d location, Velocity2d velocity, double size )
		{
			this.id       = idNext++;
			this.myField  = field;
			this.size     = size;
			this.location = location;
			this.velocity = velocity;

			this.rezinochki = new List<Rezinochka>();

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

		//[XmlElement("Color")]
		//public ColorSrz ColorForSerialization
		//{
		//	get
		//	{
		//		return new ColorSrz( this.color );
		//	}
		//	set
		//	{
		//		this.color = value;
		//	}
		//}


		public double Mass
		{
			get
			{
				return size * size * Math.PI;
			}
		}


		//goto new time
		public void GotoNewTime()
		{
			// calculate net gravity - used in calculations
			CalculateNetForce();

			// adjust velocity
			Vector2d accel = forceNet * (1 / Mass);
            velocity += accel;

			// displace by
			location.DisplaceBy( velocity );

			//// check if location is outside of bounds
			//CheckBounds();

			// check if we are overlapping with any other Things
			//CheckOverlap();

			// calculate net gravity - for display
			CalculateNetForce();

		}//GotoNewTime


		public void CalculateNetForce()
		{
			Vector2d net = new Vector2d();
			this.forceComponents = new List<Vector2d>();

			foreach ( Rezinochka r in rezinochki )
			{
				Vector2d force = r.CalculateForce( this );

				this.forceComponents.Add( force );

				net += force;
			}

			forceNet = net;
		}


		//public void CheckOverlap()
		//{
		//	List<Thing2> list = new List<Thing2>();

		//	foreach ( Thing2 t in myField.things )
		//	{
		//		if ( t == this )
		//			continue;

		//		double dist = this.CalculateSpaceBetween( t );
		//		if ( dist < 0 )
		//			list.Add( t );
		//	}

		//	if ( list.Count > 0 )
		//	{
		//		list.Add( this );
		//		myField.ScheduleCombine( list );
		//	}

		//}


		//public decimal CalculateOptimalDeltaT()
		//{
		//	if ( velocity.Length() == 0 )
		//		return Decimal.MaxValue;

		//	return (decimal)(size / velocity.Length());
		//}


		public double CalculateSpaceBetween( Thing2 t2 )
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


		//public Thing2 MakeCopy()
		//{
		//	Thing2 copy = new Thing2();

		//	copy.id       = this.id;
		//	copy.location = new Location2d( this.location );
		//	copy.velocity = new Velocity2d( this.velocity );
		//	copy.size     = this.size;
		//	copy.color    = Color.FromArgb( this.color.ToArgb() );

		//	return copy;
		//}


		//public static Thing2 Combine( List<Thing2> list )
		//{
		//	if ( list.Count < 2 )
		//		throw new PhysicsException( "Combine called with <2 items. This does not make sense." );

		//	AveragerUtil massA = new AveragerUtil();

		//	AveragerUtil colorR = new AveragerUtil();
		//	AveragerUtil colorG = new AveragerUtil();
		//	AveragerUtil colorB = new AveragerUtil();

		//	AveragerUtil locXM = new AveragerUtil();
		//	AveragerUtil locYM = new AveragerUtil();

		//	AveragerUtil velIM = new AveragerUtil();
		//	AveragerUtil velJM = new AveragerUtil();


		//	foreach ( Thing2 t in list )
		//	{
		//		massA.AddMeasurement( t.Mass );

		//		colorR.AddMeasurement( t.color.R );
		//		colorG.AddMeasurement( t.color.G );
		//		colorB.AddMeasurement( t.color.B );

		//		locXM.AddMeasurement( t.location.x * t.Mass );
		//		locYM.AddMeasurement( t.location.y * t.Mass );

		//		velIM.AddMeasurement( t.velocity.i * t.Mass );
		//		velJM.AddMeasurement( t.velocity.j * t.Mass );
		//	}

		//	// mass
		//	double size = Math.Sqrt( massA.Sum / Math.PI );

		//	// color
		//	Color color = Color.FromArgb( (int)colorR.Average, (int)colorG.Average, (int)colorB.Average );

		//	// location
		//	Location2d loc = new Location2d( locXM.Sum / massA.Sum, locYM.Sum / massA.Sum );

		//	// velocity
		//	Velocity2d vel = new Velocity2d( velIM.Sum / massA.Sum, velJM.Sum / massA.Sum );

		//	return new Thing2( list[0].myField, loc, vel, size );
		//}



		public void AttachRezinochka( Rezinochka rezinochka )
		{
			if ( this.rezinochki.Contains( rezinochka ) )
				throw new ArgumentException( "Rezinochka is already attached to this Thing2" );

			this.rezinochki.Add( rezinochka );
		}


		public void DetachRezinochka( Rezinochka rezinochka )
		{
			if ( ! this.rezinochki.Contains( rezinochka ) )
				throw new ArgumentException( "Rezinochka is not attached to this Thing2" );

			bool ok = this.rezinochki.Remove( rezinochka );

			if ( !ok )
				throw new ArgumentException( "Error while detaching Rezinochka from this Thing2" );
		}


	}//class Thing



}//ns

