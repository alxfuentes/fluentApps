using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Admin
{
    public class AppUser : DomainObject<int>
    {
        // public virtual int AppUserId { get; set; }
        public virtual string UserCode { get; set; }
        public virtual string UserName { get; set; }
        public virtual string E_Mail { get; set; }
        public virtual string Password { get; set; }
        public virtual bool Locked { get; set; }
        public virtual DateTime? ActiveFrom { get; set; }
        public virtual DateTime? ActiveTo { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public AppUser()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
