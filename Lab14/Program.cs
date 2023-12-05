using System;
using System.Reflection;
namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 14.1, метод DumpToScreen, который отображает детали банковского счета.");
            BankAcc bank = new BankAcc("Гульназ", 123456789, 5960, Type.Текущий);
            bank.DumpToScreen(); //не выводит на экран, видимо отсутствует тот самый символ условной компиляции

            Console.WriteLine("\nУпр 14.2, атрибут для записи имени разработчика класса рациональные числа");
            MemberInfo type1 = typeof(RationalNumbers);
            object[] attributes1 = type1.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes1)
            {
                if (attribute is DevelopmentInfoAttribute)
                {
                    DeveloperInfoAttribute info = (DeveloperInfoAttribute)attribute;
                    Console.WriteLine($"Разработчик: {info.DeveloperName}\nДата: {info.Date}\n"); //почему то не выводится на экран
                }
            }

            Console.WriteLine("\nДз 14.1, про атрибут для класса здания");
            MemberInfo type2 = typeof(Building);
            object[] attributes2 = type2.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes2)
            {
                if (attribute is DevelopmentInfoAttribute)
                {
                    DevelopmentInfoAttribute info = (DevelopmentInfoAttribute)attribute;
                    Console.WriteLine($"Застройщик: {info.DeveloperName}\nОрганизация: {info.OrganizationName}\n");
                }
            }
        }

    }
}
