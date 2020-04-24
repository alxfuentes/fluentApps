using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Admin.Maps
{
    public class AppUserMap : ClassMap< AppUser >
    {
        public AppUserMap()
        {
            Id(  m => m.ObjectId ).GeneratedBy.Assigned().Column("AppUserId");
            Map(m => m.UserCode).Length(32);
            Map(m => m.UserName).Length(100);
            Map(m => m.E_Mail).Length(100);
            Map(m => m.Password).Length(32);
            Map(m => m.Locked);
            Map(m => m.ActiveFrom);
            Map(m => m.ActiveTo);

            Component(m => m.RecordLog);
        }
    }
}
