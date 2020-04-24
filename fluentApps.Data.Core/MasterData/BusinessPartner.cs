using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class BusinessPartner : DomainObject<string>
    {
        // public string PartnerCode { get; set; }
        public virtual string PartnerName   { get; set; }
        public virtual string LegalName     { get; set; }
        public virtual string FiscalId      { get; set; }
        public virtual bpPaymentType PartnerType { get; set; }
        public virtual PartnerGroup Group   { get; set; }
        public virtual PartnerSegment Segment { get; set; }
        public virtual string Phone1        { get; set; }
        public virtual string Phone2        { get; set; }

        public virtual Address Billing      { get; set; }

        public virtual Address Shipping     { get; set; }

        public virtual string EMail         { get; set; }
        public virtual string WebAddress    { get; set; }

        public virtual decimal CreditLimit  { get; set; }

        public virtual bpPaymentType PaymentType { get; set; }
        public virtual int CreditDays       { get; set; }

        public virtual string Comments      { get; set; }
        public virtual DateTime? LastPurchaseDate { get; set; }

        public virtual RecordLog RecordLog  { get; set; }

        public BusinessPartner()
        {
            this.RecordLog = new RecordLog();
        }
    }

    public enum bpPaymentType
    {
        Credit,
        Cash
    }

    public enum bpPartnerType
    {
        Customer,
        Supplier,
        Bank
    }
}
