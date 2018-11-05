using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onty.Physics
{
	public class PhysicsException : Exception
	{

		// ctors
		public PhysicsException()
			: base()
		{
			
		}

		public PhysicsException( string s )
			: base( s )
		{
			
		}

		public PhysicsException( string s, Exception inner )
			: base( s, inner )
		{

		}

	}

}//ns

