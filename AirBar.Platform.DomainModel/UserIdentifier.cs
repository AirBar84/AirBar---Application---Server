using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{
    /// <summary>
    /// Simple User-ID token for passing around and referencing within the system.
    /// </summary>
    public class UserIdentifier : Element
    {
        public UserIdentifier() : 
            this(null, null)
        {
        }

        public UserIdentifier(Guid? _airbarUserIdentifierUUID, string _airbarUsername)
        {
            AirBarUserIdentifierUUID = _airbarUserIdentifierUUID;
            AirBarUsername = _airbarUsername;
        }

        public Guid? AirBarUserIdentifierUUID
        {
            get;
            set;
        }

        public string AirBarUsername
        {
            get;
            set;
        }
    }
}
