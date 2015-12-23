using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{
    public class HostRentalUnit : Element
    {
        public HostRentalUnit() : 
            this(null, null ,null, null, null)
        { 
        }

        public HostRentalUnit(string _rentalUnitName, Address _rentalUnitAddress, GeoLocation _rentalUnitGeoLocation,
            UserAccount _rentalUnitHost, List<AirBarStation> _airbarStations) 
        {
            RentalUnitName = _rentalUnitName;
            RentalUnitAddress = _rentalUnitAddress;
            RentalUnitGeoLocation = _rentalUnitGeoLocation;
            RentalUnitHost = _rentalUnitHost;
            AirbarStations = _airbarStations;
        }

        public string RentalUnitName
        {
            get;
            set;
        }

        public Address RentalUnitAddress
        {
            get;
            set;
        }

        public GeoLocation RentalUnitGeoLocation
        {
            get;
            set;
        }

        /// <summary>
        /// AirBar account of individual who rents the location, serving in the AirBnB Host Role.
        /// </summary>
        public UserAccount RentalUnitHost
        {
            get;
            set;
        } 

        public List<AirBarStation> AirbarStations
        {
            get;
            set;
        }
    }
}
