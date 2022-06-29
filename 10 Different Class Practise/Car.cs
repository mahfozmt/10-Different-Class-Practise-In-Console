using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class Car
	{
		private int _CarID;
		public int CarID
		{
			get { return _CarID; }
			set { _CarID = value; }
		}

		private string _Model;
		public string Model
		{
			get { return _Model; }
			set { _Model = value; }
		}

		private int _SpeedKMph;
		public int SpeedKMph
		{
			get { return _SpeedKMph; }
			set { _SpeedKMph = value; }
		}

		public int Accelerate()
        {
			this.SpeedKMph += 05;
			return this.SpeedKMph;
        }


	}
}
