using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;

using Onty.Physics.Util;


namespace Onty.Physics.Domain
{

	public class Field
	{

		private Dictionary<decimal, FieldState> states;
		private FieldState currentState;


		//ctors

		// default is needed for serialization
		public Field()
		{
			states = new Dictionary<decimal, FieldState>();

			currentState = new FieldState();
			currentState.myField = this;
			states.Add( currentState.time, currentState );
		}

		public Field( int nrThings )
		{
			states = new Dictionary<decimal, FieldState>();

			currentState = new FieldState();
			currentState.myField = this;
			currentState.InitItems( nrThings );
			states.Add( currentState.time, currentState );
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


		[XmlElement( "Time" )]
		public decimal time
		{
			get
			{
				return currentState.time;
			}
		}

		public List<Thing> things
		{
			get
			{
				return currentState.things;
			}
		}

		public FieldState CurrentState
		{
			get
			{
				return currentState;
			}
		}

		public Dictionary<decimal,FieldState> States
		{
			get
			{
				return states;
			}
		}


		public void GotoNewTime()
		{
			// make clone of current state
			currentState = currentState.MakeCopy();

			// perform transformations
			currentState.GotoNewTime();

			// store new state into history
			states.Add( currentState.time, currentState );
		}


		// Helper methods to get Thing by id
		public Thing GetThing( int id )
		{
			return currentState.GetThing( id );
		}


		public void RewindTo( int stateId )
		{
			if ( stateId < 0 || stateId >= states.Count )
				throw new PhysicsException( "Invalid state id" );

			FieldState fieldState = null;
			int i = 0;

			foreach ( FieldState fs in states.Values )
			{
				if ( i == stateId )
				{
					fieldState = fs;
					break;
				}
				i++;
			}

			if ( fieldState == null )
				throw new PhysicsException("RewindTo() did not find the state with id " + stateId );

			currentState = fieldState;
		}


	}//class Field


}//ns

