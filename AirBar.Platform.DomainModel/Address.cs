using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{
    public class Address : Element
    {
        public Address() : 
            this(null, null, null, null)
        {
        }

        public Address(string _street, string _city, string _state, string _zip)
        {
            Street = _street;
            City = _city;
            State = _state;
            Zip = _zip;
        }

        public string Street
        {
            get;
            set;
        } 

        public string City
        {
            get;
            set;
        }

        public string State
        {
            get;
            set;
        }

        public string Zip
        {
            get;
            set;
        }
    }
}
