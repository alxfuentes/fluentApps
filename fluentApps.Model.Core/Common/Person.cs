using System;

namespace fluentApps.Model.Core.Common
{
    public class Person
    {
        public string   FullName      { get; set; }
        public string   FirstName     { get; set; }
        public string   MiddleName    { get; set; }
        public string   LastName      { get; set; }
        public string   MaidenName    { get; set; }
        public Address  PersonAddress { get; set; }
        public string   WorkPhone     { get; set; }
        public string   ExtPhone      { get; set; }
        public string   HomePhone     { get; set; }
        public string   MobilePhone   { get; set; }
        public string   FaxPhone      { get; set; }
        public string   WorkEMail     { get; set; }
        public string   PersonalEMail { get; set; }
        public personGender Gender    { get; set; }
        public DateTime? BirthDate  { get; set; }
        public string   BirthPlace    { get; set; }
        public string   Nationality   { get; set; }
        public PersonIdType   IdType  { get; set; }
        public string   IdNumber      { get; set; }
        public string   Passport      { get; set; }
    }

    public enum personGender
    {
        Male,
        Female,
        Other
    }
}
