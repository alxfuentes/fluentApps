using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class BusinessPartnerMap : ClassMap<BusinessPartner>
    {
        public BusinessPartnerMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("PartnerId").Length(20);
            Map(m => m.PartnerName).Length(100);
            Map(m => m.LegalName).Length(100);
            Map(m => m.FiscalId).Length(32);
            Map(m => m.PartnerType);
            References(m => m.Group);
            References(m => m.Segment );
            Map(m => m.Phone1 ).Length(32);
            Map(m => m.Phone2 ).Length(32);

            Component(m => m.Billing);
            Component(m => m.Shipping);

            Map(m => m.EMail).Length(100);
            Map(m => m.WebAddress).Length(100);

            Map(m => m.CreditLimit);
            Map(m => m.PaymentType);
            Map(m => m.CreditDays);

            Map(m => m.Comments).Length(250);
            Map(m => m.LastPurchaseDate);

            Component(m => m.RecordLog);
        }
    }
}
