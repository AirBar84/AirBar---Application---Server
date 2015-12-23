using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.Model.Core
{
    public class Element
    {
        public Element() : 
            this(null, null, null)
        {
        }

        public Element(Guid? identifier, string title, List<ElementModificationRecord> modificationRecords)
        {
            Identifier = identifier;
            Title = title;
            ModificationRecords = modificationRecords;
        }

        public Guid? Identifier
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public List<ElementModificationRecord> ModificationRecords
        {
            get;
            set;
        } 
    }
}
