using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameTextToArray {
	class Program {
		static void Main( string[ ] args ) {
			Converter c = new Converter(args[0]);
		}
	}
}
