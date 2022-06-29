using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class School
	{
		private int _SchoolID;
		public int SchoolID
		{
			get { return _SchoolID; }
			set { _SchoolID = value; }
		}

		private string _Location;
		public string Location
		{
			get { return _Location; }
			set { _Location = value; }
		}

		private int _TotalStudent;
		public int TotalStudent
		{
			get { return _TotalStudent; }
			set { _TotalStudent = value; }
		}

		public int AdmitStudent(int newStudentCount)
        {
			this.TotalStudent += newStudentCount;
			return this.TotalStudent;
        }

	}
}
