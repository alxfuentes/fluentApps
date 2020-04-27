using System;
using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.MasterData
{
    public class BusinessPartner : DomainObject<string>
    {
        // public string PartnerCode { get; set; }
        public string PartnerName   { get; set; }
        public string LegalName     { get; set; }
        public string FiscalId      { get; set; }
        public bpPaymentType PartnerType { get; set; }
        public PartnerGroup Group   { get; set; }
        public PartnerSegment Segment { get; set; }
        public string Phone1        { get; set; }
        public string Phone2        { get; set; }

        public Address Billing      { get; set; }

        public Address Shipping     { get; set; }

        public string EMail         { get; set; }
        public string WebAddress    { get; set; }

        public decimal CreditLimit  { get; set; }

        public bpPaymentType PaymentType { get; set; }
        public int CreditDays       { get; set; }

        public string Comments      { get; set; }
        public DateTime? LastPurchaseDate { get; set; }

        public RecordLog RecordLog  { get; set; }

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
