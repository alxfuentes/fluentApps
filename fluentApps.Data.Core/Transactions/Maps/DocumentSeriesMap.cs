using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Transactions.Maps
{
    public class DocumentSeriesMap : ClassMap<DocumentSeries>
    {
        public DocumentSeriesMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("DocumentSeriesId");
            Map(m => m.SeriesName).Not.Nullable().Length(20);
            Map(m => m.Description).Length(100);
            Map(m => m.InitialNumber);
            Map(m => m.FinalNumber);
            Map(m => m.NextNumber);

            Component(m => m.RecordLog);
        }
    }
}
