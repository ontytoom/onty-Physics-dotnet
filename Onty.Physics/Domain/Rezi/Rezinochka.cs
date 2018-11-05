using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Onty.LibMath.Vectors;


namespace Onty.Physics.Domain.Rezi
{

	public class Rezinochka
	{

		public Thing2 a = null;
		public Thing2 b = null;
		public double k;
		
		public Color color;


		public Rezinochka( Color c, double k )
		{
			this.color = c;
			this.k = k;
		}


		public void Attach( Thing2 thing, Orientation orientation )
		{
			if ( orientation == Orientation.A )
			{
				// A
				if ( this.a != null )
				{
					this.a.DetachRezinochka( this );
				}
				this.a = thing;
				this.a.AttachRezinochka( this );
			}
			else
			{
				// B
				if ( this.b != null )
				{
					this.a.DetachRezinochka( this );
				}
				this.b = thing;
				this.b.AttachRezinochka( this );
			}
		}



		public Vector2d CalculateForce( Thing2 t )
		{
			if ( t != this.a && t != this.b )
				return new Vector2d( 0.0, 0.0 );

			double dist = Location2d.Distance( this.a.location, this.b.location );

			Thing2 ot = (t == this.a) ? this.b : this.a;

			Vector2d force = new Vector2d( t.location, ot.location );
			force.Normalize();

			force *= dist * k;

			return force;
		}


		public enum Orientation
		{
			A, B
		}

	}

}//ns

