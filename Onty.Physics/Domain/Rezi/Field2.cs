using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

using Onty.LibMath.Vectors;

using Onty.Physics.Util;


namespace Onty.Physics.Domain.Rezi
{

	public class Field2
	{

		[XmlElement("Time")]
		public int time;

		[XmlArray( "Things" )]
		public List<Thing2>     things;
		public List<Rezinochka> rezinochki;



		//ctor
		//public Field2()
		//{
		//	// needed for serialization
		//	things = new List<Thing2>();
		//}

		public Field2( int nrThings )
		{
			this.things     = new List<Thing2>( nrThings );
			this.rezinochki = new List<Rezinochka>();

			this.time     = 0;

			InitItems( nrThings );
		}


		public void GotoNewTime()
		{
			time += 1;

			// ask each thing to do its thing
			foreach ( Thing2 t in things )
				t.GotoNewTime();
		}


		[XmlElement( "Viewport" )]
		public RectangleF Viewport
		{
			get
			{
				return GlobalConfig.viewport;
			}
			set
			{
				GlobalConfig.viewport = value;
			}
		}


		public void InitItems( int nrThings )
		{
			Random r = new Random();
			int nrThingsDiscarded = 0;


			// make things
			for ( int i = 0; i < nrThings; )
			{
				double rr = r.NextDouble();
				double thingSize = rr * (GlobalConfig.sizeMax - GlobalConfig.sizeMin) + GlobalConfig.sizeMin;

				// location
				double left   = this.Viewport.Left   + thingSize;
				double right  = this.Viewport.Right  - thingSize;
				double top    = this.Viewport.Top    + thingSize;
				double bottom = this.Viewport.Bottom - thingSize;

				double x = r.NextDouble() * (right - left) + left;
				double y = r.NextDouble() * (bottom - top) + top;
				Location2d location = new Location2d( x, y );

				// check for overlap with previous things
				bool foundOverlap = false;
				foreach ( Thing2 t in things )
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

				Velocity2d velocity = new Velocity2d( 0.0, 0.0 );

				// make the thing
				Thing2 thing = new Thing2( this, location, velocity, thingSize );

				things.Add( thing );

				i++;
			}

			Util.Logger.AddMessage( "Nr things discarded: " + nrThingsDiscarded );


			// add rezinochki
			for ( int idThing = 0; idThing < things.Count - 1; idThing += 2 )
			{
				Thing2 ta = this.things[idThing];
				Thing2 tb = this.things[idThing + 1];

				Rezinochka rez = new Rezinochka( Color.LightYellow, 1.0 );

				rez.Attach( ta, Rezinochka.Orientation.A );
				rez.Attach( tb, Rezinochka.Orientation.B );

				this.rezinochki.Add( rez );
			}



		}//InitItems()


		//public decimal CalculateOptimalDeltaT()
		//{
		//	decimal optimalDeltaT = Decimal.MaxValue;

		//	foreach( Thing2 t in things )
		//	{
		//		decimal suggested = t.CalculateOptimalDeltaT();
		//		if ( suggested < optimalDeltaT )
		//			optimalDeltaT = suggested;
		//	}

		//	return optimalDeltaT;
		//}


		//private List<List<Thing>> listCombine = new List<List<Thing>>();

		//public void ScheduleCombine( List<Thing> list )
		//{
		//	// first check if it's already on the list
		//	foreach( Thing newThing in list )
		//		foreach ( List<Thing> l in listCombine )
		//			if ( l.Contains(newThing) )
		//				return;

		//	listCombine.Add( list );
		//}


		// Helper methods to get Yach and Ant by id

		public Thing2 GetThing( int id )
		{
			foreach ( Thing2 t in this.things )
				if ( t.id == id )
					return t;
			return null;
		}


	}//class Field2


}//ns

