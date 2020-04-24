using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class CurrencyMap : ClassMap< Currency >
    {
        public CurrencyMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("CurrencyId").Length(3);
            Map(m => m.CurrencyName).Length(100);
            Map(m => m.Description).Length(250);
            Map(m => m.ShortName).Length(30);
            Map(m => m.CentsName).Length(30);

            Component(m => m.RecordLog);
        }
    }
}
