using System;

namespace fluentApps.Model.Core.Common
{
    public class Schedule
    {
        public DateTime ScheduleDate        { get; set; }
        public string   ScheduleTime        { get; set; }
        public bool     Reminder            { get; set; }
        public string   ReminderSpan        { get; set; }

        public fdwScheduleFrequency Frequency { get; set; }

        public int      FrequencyEvery      { get; set; }
        public bool     FrequencyMonday     { get; set; }
        public bool     FrequencyTuesday    { get; set; }
        public bool     FrequencyWednesday  { get; set; }
        public bool     FrequencyThursday   { get; set; }
        public bool     FrequencyFriday     { get; set; }
        public bool     FrequencySaturday   { get; set; }
        public bool     FrequencySunday     { get; set; }
        public string   FrequencyTime       { get; set; }
        public int      FrequencyDate       { get; set; }
        public DateTime NextDate            { get; set; }
        public string   NextTime            { get; set; }
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
