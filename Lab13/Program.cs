using Lab13.HW13;
using System;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building House = new Building();
            Building.Fill_field();
            Console.WriteLine($"Номер дома - {House.GetNumber()}");
            Console.WriteLine($"Высота этажа - {House.Floor_hight(Building.Hight, Building.Floor)}");
            Console.WriteLine($"Кол-во квартир в подъезде - {House.Apart_in_ent(Building.Apart_num, Building.Entrance_num)}");
            byte a = House.Apart_in_ent(Building.Apart_num, Building.Entrance_num);
            Console.WriteLine($"Квартир на этаже - {House.Apart_in_floor(a, Building.Floor)}");

        }
    }
}
