using System;
using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Constraints;

using Onty.Physics.Domain;
using Onty.Physics.Util;


namespace Onty.Physics.Tests
{

	[TestFixture]
	public class Test_PhysicsException
	{

		[Test]
		public void Test_PhysicsException_A()
		{
			PhysicsException ex = new PhysicsException();

			StringAssert.Contains( "Exception of type", ex.Message );
			Assert.IsNull( ex.InnerException );
		}

		[Test]
		public void Test_PhysicsException_B()
		{
			string message = "abc";

			PhysicsException ex = new PhysicsException( message );

			Assert.AreEqual( message, ex.Message );
			Assert.IsNull( ex.InnerException );
		}

		[Test]
		public void Test_PhysicsException_C()
		{
			string message = "abc";
			ArgumentException argEx = new ArgumentException( "klm" );

			PhysicsException ex = new PhysicsException(message, argEx);

			Assert.AreEqual( message, ex.Message );
			Assert.AreEqual( argEx, ex.InnerException );
		}

	}

}//ns

