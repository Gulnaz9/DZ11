using System;

namespace Lab14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfoAttribute : Attribute //(14.2)
    {
        private string developerName;
        private string date;
        public string DeveloperName { get { return developerName; } set { developerName = value; } }
        public string Date { get { return date; } set { date = value; } }

        public DeveloperInfoAttribute(string developerName, string date)
        {
            this.developerName = developerName;
            this.date = date;
        }
    }
}
