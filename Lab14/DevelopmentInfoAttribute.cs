using System;

namespace Lab14
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DevelopmentInfoAttribute : Attribute //(дз 14.1)
    {
        private string developerName;
        private string organizationName;
        public string DeveloperName { get { return developerName; } set { developerName = value; } }
        public string OrganizationName { get { return organizationName; } set { organizationName = value; } }

        public DevelopmentInfoAttribute(string developerName, string organizationName)
        {
            this.developerName = developerName;
            this.organizationName = organizationName;
        }
    }
}
