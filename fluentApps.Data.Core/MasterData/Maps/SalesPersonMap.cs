using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class SalesPersonMap : ClassMap<SalesPerson>
    {
        public SalesPersonMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("SalesPersonId");
            Map(m => m.SalesPersonName).Not.Nullable().Length(100);
            References(m => m.Department);
            References(m => m.Branch);
            References(m => m.Employee);
            References(m => m.Manager);
            References(m => m.Channel);
            Map(m => m.Role);

            Component(m => m.RecordLog);
        }
    }
}
