using AirBar.Platform.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AirBarStationTransaction : Element
    {
        public AirBarStationTransaction() : 
            this(null, null, null, null, null)
        {

        }

        public AirBarStationTransaction(List<AirBarStationContentItem> _contentsOfPurchase, float? _purchasePriceInUSD, 
            UserIdentifier _purchaser, PaymentMethod _paymentMethod, AirBarStationTransactionStatusType? _currentTransactionStatus)
        {

        }

        public List<AirBarStationContentItem> ContentsOfPurchase
        {
            get;
            set;
        }

        public float? PurchasePriceInUSD
        {
            get;
            set;
        }

        public UserIdentifier Purchaser
        {
            get;
            set;
        }

        public PaymentMethod PaymentMethod
        {
            get;
            set;
        }

        /**
         * Enumerated Object holding the value of the current status of the transaction.
         */
        public AirBarStationTransactionStatusType? CurrentTransactionStatus
        {
            get;
            set;
        }
    }
}
