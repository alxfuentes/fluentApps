using System;

namespace fluentApps.Data.Core.Common
{
    public class Schedule
    {
        public virtual DateTime ScheduleDate        { get; set; }
        public virtual string   ScheduleTime        { get; set; }
        public virtual bool     Reminder            { get; set; }
        public virtual string   ReminderSpan        { get; set; }

        public virtual fdwScheduleFrequency Frequency { get; set; }

        public virtual int      FrequencyEvery      { get; set; }
        public virtual bool     FrequencyMonday     { get; set; }
        public virtual bool     FrequencyTuesday    { get; set; }
        public virtual bool     FrequencyWednesday  { get; set; }
        public virtual bool     FrequencyThursday   { get; set; }
        public virtual bool     FrequencyFriday     { get; set; }
        public virtual bool     FrequencySaturday   { get; set; }
        public virtual bool     FrequencySunday     { get; set; }
        public virtual string   FrequencyTime       { get; set; }
        public virtual int      FrequencyDate       { get; set; }
        public virtual DateTime NextDate            { get; set; }
        public virtual string   NextTime            { get; set; }
    }

    public enum fdwScheduleFrequency
    { 
        Minutely,
        Hourly,
        Daily,
        Weekly,
        Monthly
    }
}
