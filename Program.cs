using System;

namespace Searchy {
	class Program {

		static Searcher _searcher;

		static void Main( string[] args ) {
			_searcher = new Searcher( "BigFileSort.txt" );
			Test( "00000000000000000000" );
			Test( "0002EBLIPQ9GHAOKZ08O" );
			Test( "0003WS273DEZJWUEQZYM" );
			Test( "HDLLC9C54UE3VKA87IHA" );
			Test( "HDLLC9C54UE3VKA87IHW" );
			Test( "HDLLC9C54UE3VKA87IHZ" );
			Test( "ZZZYD2XFOSWFK6N0S4WW" );
			Test( "ZZZZK7XBJ16B5PQ8PG0B" );
			Test( "ZZZZZZZZZZZZZZZZZZZZ" );
			Console.ReadKey();
		}

		static void Test( string value ) {
			var contains = _searcher.Contains(value);
			Console.WriteLine( value + ": " + contains );
		}

	}
}
