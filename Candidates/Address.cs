namespace Candidates
{
    internal class Address
    {
        private int _house;
        public int House 
        { 
            get 
            { 
               return _house; 
            } 
            set 
            { 
                if (value > 0) 
                { 
                    _house = value;
                } 
            } 
        }

        private int _flat;

        public int Flat
        {
            get
            {
                return _flat;
            }
            set
            {
                if (value > 0)
                {
                    _flat = value;
                }
            }
        }
        public string Street { get; set; }
        public string City { get; set; }

        public Address(int house, int flat, string street, string city)
        {
            House = house;
            Flat = flat;
            Street = street;
            City = city;
        }
    }
}
