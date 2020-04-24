using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApps.Data.Core.Common
{
    public class PersonIdType : DomainObject<string>
    {
        public virtual string PersonIdName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public PersonIdType()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
