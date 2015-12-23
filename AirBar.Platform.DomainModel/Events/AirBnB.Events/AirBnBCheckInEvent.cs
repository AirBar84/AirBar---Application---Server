using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model.Events.AirBnB.Events
{
    public class AirBnBCheckInEvent : Event<AirBnBCheckInEvent>
    {

        // TODO: We're going to have to capture both checkin and checkout events... If they have checked out from AirBNB we should/it would be cool to unpair them from the station at that point.
        // TODO: Or, show them a list of Stations at that location and let them select which stations to pair with...
        // TODO: How to handle multiple people interacting with a Station (many individuals are staying at a house... they want to each have their own payment plan with the Station...

        public AirBnBCheckInEvent() : this(null, null, null)
        {
        }

        public AirBnBCheckInEvent(string _airBnbGuestAccountUsername, HostRentalUnit _hostLocation, DateTime? _checkInTime)
        {
            AirBnbGuestAccountUsername = _airBnbGuestAccountUsername;
            HostLocation = _hostLocation;
            CheckInTime = _checkInTime;
        }

        public string AirBnbGuestAccountUsername
        {
            get;
            set;
        }

        public HostRentalUnit HostLocation
        {
            get;
            set;
        } 

        public DateTime? CheckInTime
        {
            get;
            set;
        }
    }
}
