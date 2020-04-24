using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Admin
{
    public class AppRole : DomainObject<string>
    {
        // public virtual string RoleId { get; set; }

        public virtual string RoleName { get; set; }
        public virtual string Description { get; set; }
        public virtual string DesktopEnabled { get; set; }
        public virtual string WebEnabled { get; set; }
        public virtual string MobileEnabled { get; set; }
        public virtual fdwRoleType RoleType { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public AppRole()
        {
            this.RecordLog = new RecordLog();
        }
    }

    public enum fdwRoleType
    {
        Admin,
        Manager,
        Supervisor,
        Employee,
        Partner,
        Public
    }
    
    /*
    public class fdwRoleType
    {
        public static string
            Admin = "Admin",
            Manager = "Manager",
            Supervisor = "Supervisor",
            Employee = "Employee",
            Partner = "Partner",
            Public = "Public";
    }
    */
}
