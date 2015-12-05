using System;
using System.IO;

namespace Searchy {
	class Searcher {

		private string _lines;
		private int _length;

		public Searcher( string path ) {
			_lines = "\n" + File.ReadAllText( path ) + "\n";
			_length = _lines.Length;
		}

		public bool Contains( string find ) {
			find = "\n" + find + "\n";
			var low = 0;
			var high = _length;
			var length = find.Length;

			for(;;) {
				if( high - low <= 1 ) {
					return false;
				}
				var mid = ( low + high ) / 2;
				var start = _lines.LastIndexOf( '\n', mid - 1 );
				var compare = String.CompareOrdinal( _lines, start, find, 0, length );
				if( compare < 0 ) {
					low = mid;
				} else if( compare > 0 ) {
					high = mid;
				} else {
					return true;
				}
			}
		}
	}
}
