using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class Animal
	{
		private int _AnimalID;
		public int AnimalID
		{
			get { return _AnimalID; }
			set { _AnimalID = value; }
		}

		private string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private int _Weight;
		public int Weight
		{
			get { return _Weight; }
			set { _Weight = value; }
		}


		public string GetNameAndWeight()
		{
			return $"Animal Name: {Name}, and Weight: {Weight} kg";
		}

	}
}
