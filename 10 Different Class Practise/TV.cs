using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Different_Class_Practise
{
    public class TV
    {
        public TV(int TvID_, string Model_, string Power_)
        {
            this.TvID = TvID_;
            this.Model = Model_;
            this.Power = Power_;
        }
        private int _TvID;
        public int TvID
        {
            get { return _TvID; }
            set { _TvID = value; }
        }

        private string _Model;
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        private string _Power;
        public string Power
        {
            get { return _Power; }
            set { _Power = value; }
        }
        public void SetPowerOn()
        {
            this._Power = "ON";
        }

    }
}
