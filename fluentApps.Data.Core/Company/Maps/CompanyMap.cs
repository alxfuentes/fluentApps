using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("CompanyCode").Length(30);
            Map(m => m.CompanyName).Length(100);
            Map(m => m.LegalName).Length(100);
            Map(m => m.PrintHeader).Length(100);
            Map(m => m.FiscalId).Length(32);

            Component(m => m.Address);

            Map(m => m.Phone1).Length(32);
            Map(m => m.Phone2).Length(32);
            Map(m => m.Fax).Length(32);
            Map(m => m.WebSite).Length(60);
            Map(m => m.EMail).Length(60);

            Map(m => m.LegalRep).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
