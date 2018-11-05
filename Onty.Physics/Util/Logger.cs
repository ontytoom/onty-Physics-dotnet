using System;
using System.Collections.Generic;
using System.Text;


namespace Onty.Physics.Util
{

	public static class Logger
	{
		
		public static void AddMessage( string msg )
		{
			if ( GlobalConfig.LogToStdout )
			{
				Console.Error.WriteLine( msg );
				System.Diagnostics.Trace.TraceInformation( msg );
			}

		}


	}

}//ns

