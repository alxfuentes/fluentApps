using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Admin.Maps
{
    public class AppRoleMap : ClassMap< AppRole >
    {
        public AppRoleMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("RoleId").Length(30);
            Map(m => m.RoleName).Length(100);
            Map(m => m.Description).Length(256);
            Map(m => m.DesktopEnabled);
            Map(m => m.WebEnabled).Length(1);
            Map(m => m.MobileEnabled).Length(1);
            Map(m => m.RoleType); // .Length(20);
            Component(m => m.RecordLog);
        }
    }
}
