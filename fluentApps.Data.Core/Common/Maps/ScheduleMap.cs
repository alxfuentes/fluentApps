using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
public class ScheduleMap : ComponentMap<Schedule>
    {
        public ScheduleMap()
        {
            Map(m => m.ScheduleDate      );
            Map(m => m.ScheduleTime      ).Length(5);
            Map(m => m.Reminder          );
            Map(m => m.ReminderSpan      );
            Map(m => m.Frequency         );
            Map(m => m.FrequencyEvery    );
            Map(m => m.FrequencyMonday   );
            Map(m => m.FrequencyTuesday  );
            Map(m => m.FrequencyWednesday);
            Map(m => m.FrequencyThursday );
            Map(m => m.FrequencyFriday   );
            Map(m => m.FrequencySaturday );
            Map(m => m.FrequencySunday   );
            Map(m => m.FrequencyTime     ).Length(5);
            Map(m => m.FrequencyDate     );
            Map(m => m.NextDate          );
            Map(m => m.NextTime          ).Length(5);
        }
    }
}
