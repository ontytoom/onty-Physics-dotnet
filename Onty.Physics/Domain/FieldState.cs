using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

using Onty.LibMath.Vectors;

using Onty.Physics.Util;


namespace Onty.Physics.Domain
{

	public class FieldState
	{

		[XmlElement("Time")]
		public decimal time;

		[XmlArray( "Things" )]
		public List<Thing> things;

		public Field myField;


		//ctor
		public FieldState()
		{
			// needed for serialization
			things = new List<Thing>();
		}

		//public FieldState( Field field, int nrThings )
		//{
		//	this.myField  = field;
		//	this.things   = new List<Thing>( nrThings );
		//	this.time     = 0;

		//	InitItems( nrThings );
		//}


		public void GotoNewTime()
		{
			decimal deltaT = CalculateOptimalDeltaT();

			time += deltaT;

			// ask each thing to do its thing
			foreach ( Thing t in things )
				t.GotoNewTime( deltaT );

			// if any Things need to be combined
			foreach ( List<Thing> list in listCombine )
			{
				Thing combinedThing = Thing.Combine( list );
				things.Add( combinedThing );

				foreach( Thing t in list)
					things.Remove( t );
			}
			listCombine.Clear();
		}


		public void InitItems( int nrThings )
		{
			Random r = new Random();
			int nrThingsDiscarded = 0;

			// the sun
			Location2d sunLoc = new Location2d( GlobalConfig.viewport.Left + GlobalConfig.viewport.Width / 2, GlobalConfig.viewport.Top + GlobalConfig.viewport.Height / 2 );
			Velocity2d sunVel = new Velocity2d( 0, 0 );
			Thing sun = new Thing( this, sunLoc, sunVel, 14 );
			things.Add( sun );


			// make things
			for ( int i = 0; i < nrThings-1; )
			{
				// if nrDiscarded is too high, we need to exit
				if ( nrThingsDiscarded / nrThings > 71 )
					throw new PhysicsException( "Please lower Nr Things, they are not fitting" );

				double rr = r.NextDouble();
				double thingSize = rr * (GlobalConfig.sizeMax - GlobalConfig.sizeMin) + GlobalConfig.sizeMin;

				// location
				double left   = myField.Viewport.Left   + thingSize;
				double right  = myField.Viewport.Right  - thingSize;
				double top    = myField.Viewport.Top    + thingSize;
				double bottom = myField.Viewport.Bottom - thingSize;

				double x = r.NextDouble() * (right - left) + left;
				double y = r.NextDouble() * (bottom - top) + top;
				Location2d location = new Location2d( x, y );

				// check for overlap with previous things
				bool foundOverlap = false;
				foreach ( Thing t in things )
				{
					double dist = t.CalculateSpaceBetween( location, thingSize );
					if ( dist < 0 )
					{
						foundOverlap = true;
						break;
					}
				}

				if ( foundOverlap )
				{
					nrThingsDiscarded++;
					continue;
				}

				// velocity: get vector in direction of the sun, and then rotate it left or right
				Vector2d vel = new Vector2d( location, sun.location );
				vel.Normalize();
				vel.Rotate( r.Next() == 0 ? -Math.PI/2 : Math.PI/2 );
				double coeff = r.NextDouble() * GlobalConfig.velocityMax;
				vel = vel * coeff;
				Velocity2d velocity = new Velocity2d( vel );

				// make the thing
				Thing thing = new Thing( this, location, velocity, thingSize );

				things.Add( thing );

				i++;
			}

			Util.Logger.AddMessage( "Nr things discarded: " + nrThingsDiscarded);

		}//InitItems()


		public decimal CalculateOptimalDeltaT()
		{
			decimal optimalDeltaT = Decimal.MaxValue;

			foreach( Thing t in things )
			{
				decimal suggested = t.CalculateOptimalDeltaT();
				if ( suggested < optimalDeltaT )
					optimalDeltaT = suggested;
            }

			return optimalDeltaT;
		}


		private List<List<Thing>> listCombine = new List<List<Thing>>();

		public void ScheduleCombine( List<Thing> list )
		{
			// first check if it's already on the list
			foreach( Thing newThing in list )
				foreach ( List<Thing> l in listCombine )
					if ( l.Contains(newThing) )
						return;

			listCombine.Add( list );
		}


		// Helper methods to get Yach and Ant by id

		public Thing GetThing( int id )
		{
			foreach ( Thing t in this.things )
				if ( t.id == id )
					return t;
			return null;
		}


		public FieldState MakeCopy()
		{
			FieldState copy = new FieldState();

			// copy basic values
			copy.time = time;
			copy.myField = myField;

			// copy things
			foreach( Thing t in things )
			{
				Thing t2 = t.MakeCopy();
				t2.myField = copy;
                copy.things.Add( t2 );
			}

			return copy;
		}


	}//class Field


}//ns

