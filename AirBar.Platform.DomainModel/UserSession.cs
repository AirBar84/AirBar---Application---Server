using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{
    public class UserSession : Element
    {
        public UserSession() : 
            this(null, null, null, null, null)
        {
        }

        public UserSession(Guid? _sessionIdentifier, string _airbarUsername, DateTime? _sessionBeginTime, 
            DateTime? _sessionEndTime, UserSessionStateType? _currentSessionState)
        {
            SessionIdentifier = _sessionIdentifier;
            AirbarUsername = _airbarUsername;
            SessionBeginTime = _sessionBeginTime;
            SessionEndTime = _sessionEndTime;
            CurrentSessionState = _currentSessionState;
        }

        public Guid? SessionIdentifier
        {
            get;
            set;
        }

        public string AirbarUsername
        {
            get;
            set;
        }

        public DateTime? SessionBeginTime
        {
            get;
            set;
        }

        public DateTime? SessionEndTime
        {
            get;
            set;
        }

        public UserSessionStateType? CurrentSessionState
        {
            get;
            set;
        }

        public static UserSession CurrentSession()
        {
            throw new NotImplementedException("Not implemented...");
        }
    }

}
