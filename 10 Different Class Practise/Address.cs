namespace _10_Different_Class_Practise
{
    public class Address
    {
        public Address()
        {
        }
        public Address(string Village_, string Thana_, string District_)
        {
            this.Village = Village_;
            this.Thana = Thana_;
            this.District = District_;
        }
        private string _Village;
        public string Village
        {
            get { return _Village; }
            set { _Village = value; }
        }

        private string _Thana;
        public string Thana
        {
            get { return _Thana; }
            set { _Thana = value; }
        }

        private string _District;
        public string District
        {
            get { return _District; }
            set { _District = value; }
        }
        public string GetFullAdress()
        {
            return this.Village + ", " + this.Thana + ", " + this.District;
        }
    }
}
