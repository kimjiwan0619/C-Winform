using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birethday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> MyPets
        {
            get { return _MyPets; }
        }
        public bool Adopt(Pet pet)
        {
            if(_IsQualified)
            {
                MyPets.Add(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer(string firstname, string lastname, DateTime birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this._Birethday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birethday; }
            set
            {
                _Birethday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birethday.Year; }
        }

        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
