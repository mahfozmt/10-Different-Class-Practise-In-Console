using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class Student
	{
		private int _StudentID;
		public int StudentID
		{
			get { return _StudentID; }
			set { _StudentID = value; }
		}

		private string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private string _StudyingClass;
		public string StudyingClass
		{
			get { return _StudyingClass; }
			set { _StudyingClass = value; }
		}

		private int _RollNumber;
		public int RollNumber
		{
			get { return _RollNumber; }
			set { _RollNumber = value; }
		}

		public string getStudyingClass()
        {
			return _StudyingClass;
        }
	}
}
