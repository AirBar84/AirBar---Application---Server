using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{

    /**
     * Represents the AirBar Station at the Host Location.
     *
     * Created by brian on 12/11/2015.
     */
    

    public class AirBarStation : Element
    {
        public AirBarStation() : this(null, null, null, null, null)
        {
        }

        public AirBarStation(string _stationTitle, HostRentalUnit _hostUnitOfStation, List<UserIdentifier> _currentlyPairedUsers, 
            List<AirBarStationContentItem> _currentContents, Dictionary<UserIdentifier, List<AirBarStationTransaction>> _transactionsForCurrentlyPaired)
        {
            StationTitle = _stationTitle;
            HostUnitOfStation = _hostUnitOfStation;
            CurrentlyPairedUsers = _currentlyPairedUsers;
            CurrentContents = _currentContents;
            TransactionsForPairedUsers = _transactionsForCurrentlyPaired;
        }

        public string StationTitle
        {
            get;
            set;
        }

        public HostRentalUnit HostUnitOfStation
        {
            get;
            set;
        } 

        public List<UserIdentifier> CurrentlyPairedUsers
        {
            get;
            set;
        }

        public List<AirBarStationContentItem> CurrentContents
        {
            get;
            set;
        }

        public Dictionary<UserIdentifier, List<AirBarStationTransaction>> TransactionsForPairedUsers
        {
            get;
            set;
        }

        public List<AirBarStationTransaction> TransactionsForPairedUser(UserIdentifier _userIdentifier)
        {
            if (TransactionsForPairedUsers != null && TransactionsForPairedUsers.Count > 0)
            {
                return TransactionsForPairedUsers[_userIdentifier];
            }
            return new List<AirBarStationTransaction>();
        }
    }
}
