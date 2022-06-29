using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
    public class Employee
    {
        public Employee(int EmployeeID_, string Department_, int Salary_)
        {
            this.EmployeeID = EmployeeID_;
            this.Department = Department_;
            this.Salary = Salary_;
        }
        private int _EmployeeID;
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        private string _Department;
        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }

        private int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string ChangeDepartmnet(string newDepartment)
        {
            this._Department = newDepartment;
            return this.Department;
        }
    }
}
