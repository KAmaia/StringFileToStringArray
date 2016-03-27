using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameTextToArray {
	public class Converter {
		private List<string> names;
		public Converter(string fileName ) {
			names = new List<string>( );
			ReadFile( fileName );
			SaveFile( fileName );
		}
		private void SaveFile(string fileName ) {
			string newFileName = fileName.Remove(fileName.LastIndexOf('.'));
			newFileName += "_converted.txt";
			File.WriteAllLines( newFileName, names.ToArray( ) );
		}
		private void ReadFile( string fileName ) {
			string[] rawData = File.ReadAllLines( fileName );
			
			foreach(string s in rawData ) {
				string nameToAdd = "\"" + s.Split('\t')[0] + "\",";
				names.Add( nameToAdd );
			}
		}
	}

}
