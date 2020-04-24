using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class PriceListMap : ClassMap<PriceList>
    {
        public PriceListMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("PriceListId");
            Map(m => m.PriceListName).Length(100);
            Map(m => m.Description  ).Length(250);
            References(m => m.Branch);
            Map(m => m.PriceLevel   );
            Map(m => m.StartDate    );
            Map(m => m.EndDate );
           
            Component(m => m.RecordLog);
        }
    }
}
