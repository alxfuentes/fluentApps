using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Location : DomainObject<int>
    {
        // public int LocationId {get;set;}
        public string LocationName { get; set; }

        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public Location()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
