using System;

namespace fluentApps.Data.Core.Common
{
    public class Person
    {
        public virtual string   FullName      { get; set; }
        public virtual string   FirstName     { get; set; }
        public virtual string   MiddleName    { get; set; }
        public virtual string   LastName      { get; set; }
        public virtual string   MaidenName    { get; set; }
        public virtual Address  PersonAddress { get; set; }
        public virtual string   WorkPhone     { get; set; }
        public virtual string   ExtPhone      { get; set; }
        public virtual string   HomePhone     { get; set; }
        public virtual string   MobilePhone   { get; set; }
        public virtual string   FaxPhone      { get; set; }
        public virtual string   WorkEMail     { get; set; }
        public virtual string   PersonalEMail { get; set; }
        public virtual personGender Gender    { get; set; }
        public virtual DateTime? BirthDate  { get; set; }
        public virtual string   BirthPlace    { get; set; }
        public virtual string   Nationality   { get; set; }
        public virtual PersonIdType   IdType  { get; set; }
        public virtual string   IdNumber      { get; set; }
        public virtual string   Passport      { get; set; }
    }

    public enum personGender
    {
        Male,
        Female,
        Other
    }
}
