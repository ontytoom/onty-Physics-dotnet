using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace Onty.Physics.Tests
{

	[TestFixture]
	public class Test_Output
	{

		[Test]
		public void Test_Output_01()
		{
			Console.Out.WriteLine( "This was generated using Console.Out.WriteLine" );
			Trace.WriteLine("This was generated using Trace.WriteLine");
		}

	}



}//ns

