//Write to CSV file from list of waveform objects
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Wave
{
	public class CSVWriter
	{
		private string filename;
		List <WaveForm> waves;
		public CSVWriter (string file, List<WaveForm> listwave)
		{
			filename = file;
			waves = listwave;
		}

		public void writeCsv ()
		{
			using (StreamWriter sw = new StreamWriter (filename)) {

				sw.WriteLine ("Filename,Frequency");
				foreach (WaveForm wave in waves) {
					sw.WriteLine (wave.toString());
				}
			}
		}

		public string getFilename(){		
			return filename;
		}

	}
}

