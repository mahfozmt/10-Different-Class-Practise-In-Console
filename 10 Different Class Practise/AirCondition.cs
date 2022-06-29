using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class AirCondition
	{
		private int _AirConditionID;
		public int AirConditionID
		{
			get { return _AirConditionID; }
			set { _AirConditionID = value; }
		}

		private string _Model;
		public string Model
		{
			get { return _Model; }
			set { _Model = value; }
		}

		private int _Temperature;
		public int Temperature
		{
			get { return _Temperature; }
			set { _Temperature = value; }
		}

		public int setTemperature(int celcius)
        {
			this.Temperature = celcius;
			return this.Temperature;
        }
	}
}
