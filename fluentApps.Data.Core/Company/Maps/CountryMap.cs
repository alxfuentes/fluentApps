using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class CountryMap : ClassMap< Country >
    {
        public CountryMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("CountryId").Length(3);
            Map(m => m.CountryName).Length(100);
            Map(m => m.ISOCode2).Length(2);
            Map(m => m.ISOCode3).Length(3);
            Map(m => m.UNCode);
            Map(m => m.DialingCode).Length(10);

            References(m => m.Currency);

            Component(m => m.RecordLog);
        }
    }
}
