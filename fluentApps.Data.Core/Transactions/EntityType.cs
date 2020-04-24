using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.Admin;

namespace fluentApps.Data.Core.Transactions
{
    public class EntityType : DomainObject<int>
    {
        public virtual string EntityName { get; set; }
        public virtual string Description { get; set; }
        public virtual AppCatalog AppCatalog { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public EntityType()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
