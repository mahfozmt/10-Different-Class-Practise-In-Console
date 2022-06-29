using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class Customer
	{
		private int _CustomerID;
		public int CustomerID
		{
			get { return _CustomerID; }
			set { _CustomerID = value; }
		}

		private string _ShippingAddress;
		public string ShippingAddress
		{
			get { return _ShippingAddress; }
			set { _ShippingAddress = value; }
		}

		public string getShippingAddress() { return _ShippingAddress; }
	}
}
