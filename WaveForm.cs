//The wave form object is create with the highest amplitude wave in the CSV File

using System;

namespace Wave
{
	public class WaveForm 
	{
		private float amplitude = 0;
		private float period = 0;
		private float frequency;
		private string filename;
		public WaveForm (string name,float amp,float time)
		{			
			filename = name;
			amplitude = amp;
			period = time;
		}

		public float getAmplitude(){
			return amplitude;
		}
		public float getPeriod(){
			return period;
		}
		public float getFrequency(){
			frequency = 1 / period;
			return frequency;
		}
		public string getFileName(){

			return filename;
		}
		public string toString(){
			return getFileName() + "," + getFrequency();
		}
//		public int CompareTo(object obj){
//			if (obj == null)
//				return 1;
//			WaveForm nuwave = obj as WaveForm;
//			if (nuwave != null)
//				return this.frequency.CompareTo(nuwave.frequency);
//			else
//				throw new ArgumentException("That worked out fine in my head...");
//		}

	}
}

