using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Admin.Maps
{
    public class AppMenuOptionMap : ClassMap< AppMenuOption >
    {
        public AppMenuOptionMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("OptionId");
            References(m => m.App).Column("AppId");
            Map(m => m.ParentId);
            Map(m => m.OptionName).Length(100);
            Map(m => m.Description).Length(256);
            Map(m => m.Assembly).Length(256);
            Map(m => m.OptionPath).Length(256);
            Map(m => m.WebView).Length(1);
            Map(m => m.Param1).Length(256);
            Map(m => m.Param2).Length(256);
            Map(m => m.Param3).Length(256);
            Map(m => m.OpenMode).Length(10);
            Map(m => m.IconName).Length(256);
            Map(m => m.DesktopIcon);
            Component(m => m.RecordLog);
        }
    }
}
