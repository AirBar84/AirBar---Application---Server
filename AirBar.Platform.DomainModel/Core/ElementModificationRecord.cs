using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model.Core
{
    /// <summary>
    /// Represents a record of Modifications tha were applied to a specific element-instance.
    /// </summary>
    public class ElementModificationRecord
    {
        /// <summary>
        /// Inner Class representing modifications to Field-Records.
        /// </summary>
        public class FieldModificationRecord
        {
            public string FieldName { get; set; }
            public object PreviousValue { get; set; }
            public object CurrentValue { get; set; }
        }


        public ElementModificationRecord() : 
            this(null, null, null, null)
        {
        }

        public ElementModificationRecord(DateTime? _timestamp, ElementModificationEventType? _modificationEventType, 
            List<FieldModificationRecord> _fieldChangesets, UserSession _sessionModifiedBy)
        {
            Timestamp = _timestamp;
            ModificationEventType = _modificationEventType;
            FieldChangesets = _fieldChangesets;
            SessionModifiedBy = _sessionModifiedBy;
        }

        public DateTime? Timestamp
        {
            get;
            set;
        }

        public ElementModificationEventType? ModificationEventType
        {
            get;
            set;
        }

        public List<FieldModificationRecord> FieldChangesets
        {
            get;
            set;
        }

        public UserSession SessionModifiedBy
        {
            get;
            set;
        }
    }
}
