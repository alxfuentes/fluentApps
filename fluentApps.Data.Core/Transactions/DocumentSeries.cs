using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Transactions
{
    public class DocumentSeries : DomainObject<int>
    {
        public virtual string SeriesName { get; set; }
        public virtual string Description { get; set; }
        public virtual int InitialNumber { get; set; }
        public virtual int FinalNumber { get; set; }
        public virtual int NextNumber { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public DocumentSeries()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
