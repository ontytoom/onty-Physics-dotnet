using System;
using System.Collections.Generic;
using System.Text;


namespace Physics.Util
{

	public class StatsCollector
	{
		// data
		double lower;
		double upper;
		double bucketSize;
		int nrBuckets;
		double[] markers;
		int[] buckets;
		int nrMeasurements;


		// ctor
		public StatsCollector( double lower, double upper, int nrBuckets )
		{
			this.lower = lower;
			this.upper = upper;
			this.nrBuckets = nrBuckets;
			this.nrMeasurements = 0;

			this.bucketSize = (upper - lower) / nrBuckets;

			// markers
			this.markers = new double[nrBuckets + 1];

			for ( int b = 0; b < nrBuckets; b++ )
				markers[b] = bucketSize * b + lower;

			markers[nrBuckets] = upper;

			// actual buckets
			this.buckets = new int[nrBuckets];
			for ( int b = 0; b < nrBuckets; b++ )
				buckets[b] = 0;

		}


		public void AddMeasure( double m )
		{
			if ( m < markers[0] )
				throw new Exception( "Measure below lower" );

			if ( m > markers[nrBuckets] )
				throw new Exception( "Measure above upper" );

			bool found = false;
			for ( int b = 0; b < nrBuckets; b++ )
				if ( m >= markers[b] && m < markers[b + 1] )
				{
					buckets[b]++;
					found = true;
					break;
				}

			if ( !found )
				throw new Exception( "Hmmmm did not find the bucket but should have" );

			nrMeasurements++;
		}


		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine( "lower=" + lower.ToString( "0.000" ) );
			sb.AppendLine( "upper=" + upper.ToString( "0.000" ) );
			sb.AppendLine( "bucketSize=" + bucketSize.ToString( "0.000" ) );
			sb.AppendLine( "nrMeasurements=" + nrMeasurements );

			//sb.Append( "bucket markers: " );
			//for ( int b = 0; b <= nrBuckets; b++ )
			//	sb.Append( markers[b].ToString( "0.000" ) + " " );
			//sb.AppendLine();

			sb.Append( "buckets: " );
			for ( int b = 0; b < nrBuckets; b++ )
			{
				sb.Append( buckets[b] );
				if ( b < nrBuckets-1 )
					sb.Append( ", " );
			}
			sb.AppendLine();

			return sb.ToString();
		}


	}
}


