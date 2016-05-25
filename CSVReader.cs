//Read CSV file
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace Wave
{
	public class CSVReader
	{	
		private string file;
		float amp = -10.00f;
		float time = 0.00f;
		WaveForm wave;
		string filename;
		public CSVReader (string filePath,string name)
		{
			file = filePath;
			filename = name;
		}

		public WaveForm readCSV(){

			try
			{
				// Create an instance of StreamReader to read from a file.
				// The using statement also closes the StreamReader.
				using (StreamReader sr = new StreamReader(file))
				{

					string line;
					string[] row;
					//Read first line
					sr.ReadLine();
					// Read and display lines from the file until 
					// the end of the file is reached. 
					while ((line = sr.ReadLine()) != null)
					{
						row = line.Split(',');
						//Store the highest amplitude value read by the string reader
						if(amp < (float.Parse(row.GetValue(1).ToString())) )
						{
							amp = (float.Parse(row.GetValue(1).ToString()));
							time = (float.Parse(row.GetValue(0).ToString()));
						}
					}
				}
				//Create wave object for wave with highest amplitude
				wave = new WaveForm(filename,amp,time);
			}
			catch (Exception e)
			{
				// Error Message.
				Console.WriteLine(e.Message);
			}

			return wave;
		}
	}
}

