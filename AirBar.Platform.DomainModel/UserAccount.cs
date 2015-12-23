using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{

    public class UserAccount : Element
    {
        /// <summary>
        /// An enumerated type designating differnt types of accounts within the AirBar/AirBnB System.
        /// </summary>
        public enum UserAccountType
        {
            /// <summary>
            /// An Account for a Host, a user of AirBnB who is putting a room up for rent.
            /// </summary>
            Host,

            /// <summary>
            /// An Account for a Guest, a user of AirBnB who is staying at a rented room or building (i.e. house).
            /// </summary>
            Guest
        }

        public UserAccount() : 
            this(null, null, null, null, null, null, null)
        {
        }

        /// <summary>
        /// Properties constructor for Account Class.
        /// </summary>
        /// <param name="_accountType"></param>
        /// <param name="_airbarUsername"></param>
        /// <param name="_emailAddress"></param>
        /// <param name="_firstName"></param>
        /// <param name="_lastName"></param>
        /// <param name="_birthdate"></param>
        /// <param name="_paymentMethods"></param>
        public UserAccount(UserAccountType? _accountType, string _airbarUsername, string _emailAddress, string _firstName, 
            string _lastName, DateTime? _birthdate, List<PaymentMethod> _paymentMethods)
        {
            AccountType = _accountType;
            AirbarUsername = _airbarUsername;
            EmailAddress = _emailAddress;
            FirstName = _firstName;
            LastName = _lastName;
            Birthdate = _birthdate;
            PaymentMethods = _paymentMethods;
        }

        public UserAccountType? AccountType
        {
            get;
            set;
        } 

        public string AirbarUsername
        {
            get;
            set;
        }

        public string EmailAddress
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public DateTime? Birthdate
        {
            get;
            set;
        }

        public List<PaymentMethod> PaymentMethods
        {
            get;
            set;
        } 
    }
}
