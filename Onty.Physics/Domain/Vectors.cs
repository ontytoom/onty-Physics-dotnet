using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace Physics.Domain
{

	public class Location
	{
		[XmlAttribute]
		public double x, y;

		// ctors
		public Location()
		{
		}

		public Location( double x, double y )
		{
			this.x = x;
			this.y = y;
		}

		public Location( Location locationToCopy )
		{
			this.x = locationToCopy.x;
			this.y = locationToCopy.y;
		}


		// operators

		public static bool operator == (Location loc1, Location loc2)
		{
			// If both are null, or both are same instance, return true.
			if ( ReferenceEquals( loc1, loc2 ) )
				return true;

			// If one is null, but not both, return false.
			if ( ReferenceEquals( loc1, null ) || ReferenceEquals( loc2, null ) )
				return false;

			return (loc1.x == loc2.x) && (loc1.y == loc2.y);
		}

		public static bool operator !=( Location loc1, Location loc2 )
		{
			return !(loc1 == loc2);
		}

		public override bool Equals( object loc2 )
		{
			if ( loc2 == null )
				return false;
			if ( loc2.GetType().FullName != this.GetType().FullName )
				return false;
			Location loc2b = (Location)loc2;
			return (this.x == loc2b.x) && (this.y == loc2b.y);
		}

		// Displace by velocity
		public void DisplaceBy( Velocity v )
		{
			x += v.i;
			y += v.j;
		}


		// ToString
		public override string ToString()
		{
			return "[x=" + string.Format( "{0:0.0}", x ) + " y=" + string.Format( "{0:0.0}", y ) + "]";
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}


	public class Velocity : Vector
	{
		//ctors
		public Velocity()
		{
		}

		public Velocity( double i, double j )
		{
			this.i = i;
			this.j = j;
		}

		public Velocity( Velocity velocityToCopy )
		{
			this.i = velocityToCopy.i;
			this.j = velocityToCopy.j;
		}

		public Velocity( Vector vectorToCopy )
		{
			this.i = vectorToCopy.i;
			this.j = vectorToCopy.j;
		}


		// operators

		public override bool Equals( object vel2 )
		{
			if ( vel2 == null )
				return false;
			if ( vel2.GetType().FullName != this.GetType().FullName )
				return false;
			Velocity vel2b = (Velocity)vel2;
			return (this.i == vel2b.i) && (this.j == vel2b.j);
		}

		public static bool operator ==( Velocity v1, Velocity v2 )
		{
			// If both are null, or both are same instance, return true.
			if ( ReferenceEquals( v1, v2 ) )
				return true;

			// If one is null, but not both, return false.
			if ( ReferenceEquals( v1, null ) || ReferenceEquals( v2, null ) )
				return false;

			return (v1.i == v2.i) && (v1.j == v2.j);
		}

		public static bool operator !=( Velocity vel1, Velocity vel2 )
		{
			return !(vel1 == vel2);
		}


		public static Velocity operator +( Velocity vel, Vector vec )
		{
			return new Velocity( vel.i + vec.i, vel.j + vec.j );
		}


		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}


	public class Vector
	{
		[XmlAttribute]
		public double i, j;

		public Vector()
		{
		}

		public Vector( double i, double j)
		{
			this.i = i;
			this.j = j;
		}

		public Vector( Vector v2 )
		{
			this.i = v2.i;
			this.j = v2.j;
		}

		public void MakeUnitVector()
		{
			double abs = Length();
			i /= abs;
			j /= abs;
		}

		public double Length()
		{
			return Math.Sqrt( i * i + j * j );
		}


		public static Vector FromTo( Location loc1, Location loc2 )
		{
			Vector v = new Vector();
			v.i = loc2.x - loc1.x;
			v.j = loc2.y - loc1.y;

			return v;
		}


		public void Rotate( double rotationInRadians )
		{
			// if vector has no length, do nothing
			if ( i == 0.0 && j == 0.0 )
				return;

			double abs = Length();
			double angle = Math.Atan( j / i );

			if ( Math.Sign( i ) == -1 )
				angle += Math.PI;

			angle += rotationInRadians;

			double i2 = abs * Math.Cos( angle );
			double j2 = abs * Math.Sin( angle );

			i = i2;
			j = j2;
		}



		public override bool Equals( object vec2 )
		{
			if ( vec2 == null )
				return false;
			if ( vec2.GetType().FullName != this.GetType().FullName )
				return false;
			Vector vec2b = (Vector)vec2;
			return (this.i == vec2b.i) && (this.j == vec2b.j);
		}

		public static Vector operator +( Vector v1, Vector v2 )
		{
			return new Vector( v1.i + v2.i, v1.j + v2.j );
		}

		public static Vector operator *( Vector v1, decimal coeff )
		{
			return new Vector( v1.i * (double)coeff, v1.j * (double)coeff );
		}

		public static Vector operator *( Vector v1, double coeff )
		{
			return new Vector( v1.i * coeff, v1.j * coeff );
		}

		public static bool operator ==( Vector v1, Vector v2 )
		{
			// If both are null, or both are same instance, return true.
			if ( ReferenceEquals( v1, v2 ) )
				return true;

			// If one is null, but not both, return false.
			if ( ReferenceEquals( v1, null ) || ReferenceEquals( v2, null ) )
				return false;

			return (v1.i == v2.i) && (v1.j == v2.j);
		}

		public static bool operator !=( Vector v1, Vector v2 )
		{
			return !(v1 == v2);
		}


		public override string ToString()
		{
			string typeName = this.GetType().Name;
			return typeName + "(i=" + string.Format( "{0:0.0}", i ) + " j=" + string.Format( "{0:0.0}", j ) + ")";
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}


}//ns

