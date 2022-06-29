using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
	public class Book
	{
		private string _Title;
		public string Title
		{
			get { return _Title; }
			set { _Title = value; }
		}

		private string _Author;
		public string Author
		{
			get { return _Author; }
			set { _Author = value; }
		}

		private DateTime _PublishDate;
		public DateTime PublishDate
		{
			get { return _PublishDate; }
			set { _PublishDate = value; }
		}

		public string GetAuthor()
        {
			return _Author;
        }
	}
}
