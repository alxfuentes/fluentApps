using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentApps.Model.Core.Common
{
    public class PersonIdType : DomainObject<string>
    {
        public string PersonIdName { get; set; }
        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public PersonIdType()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
