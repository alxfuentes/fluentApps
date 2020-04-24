using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Admin.Maps
{
    public class AppCatalogMap : ClassMap<AppCatalog>
    {
        public AppCatalogMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("AppId").Length(20);
            Map(m => m.AppName).Length(100);
            Map(m => m.Description).Length(256);
            Map(m => m.IconName).Length(256);
            Map(m => m.MenuOrder);
            Component(m => m.RecordLog);
        }
    }
}
