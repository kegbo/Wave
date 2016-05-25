using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Wave
{
	class MainClass
	{
		public static void Main (string[] args)
	{
		string path = "wav/";
		string searchPattern = "*.csv";
		//List of all wave objects created with highest amplitude in file
		List <WaveForm> wave = new List<WaveForm> ();
		

		//List of all the files in directory
		string[] Dir = Directory.GetFiles (path, searchPattern);

		foreach(string file in Dir){
				
			//format filepath to get file name
			int len = file.Length - 4;
			string fileName = file.Remove (len, 4);
			fileName = fileName.Remove (0, 4);			
			//Reading csv files
			CSVReader csvReader = new CSVReader (file,fileName);
			wave.Add(csvReader.readCSV ());
		}
		//sort the elements in the list by the frequency
		//Then Write to Csv output file
		List<WaveForm> nuwave = wave.OrderBy(WaveForm=>WaveForm.getFrequency()).ToList();
		CSVWriter csvWriter = new CSVWriter ("Output.csv", nuwave);
		csvWriter.writeCsv ();
		}
	}
}
