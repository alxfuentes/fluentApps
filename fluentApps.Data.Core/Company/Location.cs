using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Location : DomainObject<int>
    {
        // public virtual int LocationId {get;set;}
        public virtual string LocationName { get; set; }

        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Location()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
