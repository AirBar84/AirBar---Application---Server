using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model.Events
{
    /// <summary>
    /// Base Event Class. Provides the basic information for uniquely identifying an Event, Who created it, and, what it's Concrete/Specialized type is.
    /// </summary>
    /// <typeparam name="TEventType"></typeparam>
    public class Event<TEventType> where TEventType : new()
    {
        public Event() : 
            this(Guid.NewGuid(), DateTime.Now, default(TEventType), null)
        {
        }

        public Event(Guid? eventIdentifier, DateTime? timestamp, TEventType eventType, UserIdentifier initiatingUser)
        {
            EventIdentifier = eventIdentifier;
            Timestamp = timestamp;
            EventType = eventType;
            InitiatingUser = initiatingUser;
        }

        public Guid? EventIdentifier
        {
            get;
            set;
        }

        public DateTime? Timestamp
        {
            get;
            set;
        }

        public TEventType EventType
        {
            get;
            set;
        }

        public UserIdentifier InitiatingUser
        {
            get;
            set;
        }
    }
}
