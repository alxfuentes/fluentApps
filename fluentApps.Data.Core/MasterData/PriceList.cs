using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.Company;

namespace fluentApps.Data.Core.MasterData
{
    public class PriceList : DomainObject<int>
    {
        public virtual string PriceListName { get; set; }
        public virtual string Description { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual prPriceLevel PriceLevel { get; set;}

        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public PriceList()
        {
            this.RecordLog = new RecordLog();
        }
    }

    public enum prPriceLevel
    {
        Retail,
        Wholesale,
        Distributor,
        Special
    }
}
