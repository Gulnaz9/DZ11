using System;

namespace Lab14
{

    [DevelopmentInfo("Гульназ", "YG Partnership")]
    internal class Building
    {
        private static byte num;
        private static double hight;
        private static byte floor;
        private static byte apart_num;
        private static byte entrance_num;
        public static byte Num { get { return num; } set { num = value; } }
        public static double Hight { get { return hight; } set { hight = value; } }
        public static byte Floor { get { return floor; } set { floor = value; } }
        public static byte Apart_num { get { return apart_num; } set { apart_num = value; } }
        public static byte Entrance_num { get { return entrance_num; } set { entrance_num = value; } }


        /// <summary>
        /// метод вычисления высоты этажа
        /// </summary>
        /// <param name="Hight"></param>
        /// <param name="Floor"></param>
        /// <returns></returns>
        public double Floor_hight(double Hight, byte Floor)
        {
            return Hight / Floor;
        }

        /// <summary>
        /// метод вычисления квартир в подъезде
        /// </summary>
        /// <param name="Apart_num"></param>
        /// <param name="Entrance_num"></param>
        /// <returns></returns>
        public byte Apart_in_ent(byte Apart_num, byte Entrance_num)
        {
            return (byte)(Apart_num / Entrance_num);
        }

        /// <summary>
        /// метод вычисления квартир на этаже
        /// </summary>
        /// <param name="apart_in_ent"></param>
        /// <param name="Floor"></param>
        /// <returns></returns>
        public byte Apart_in_floor(byte apart_in_ent, byte Floor)
        {
            return (byte)(apart_in_ent / Floor);
        }

        /// <summary>
        /// метод генерации номера дома
        /// </summary>
        /// <returns></returns>
        public byte GetNumber()
        {
            Random random = new Random(1);
            return (byte)(random.Next(1, byte.MaxValue));
        }


        public static void Fill_field()
        {
            try
            {
                Console.WriteLine("Введите высоту дома");
                double highT = double.Parse(Console.ReadLine());
                if (highT <= 0)
                {
                    Console.WriteLine("Высота не может быть отрицательной");
                    Environment.Exit(0);
                }
                else
                {
                    Hight = highT;
                }
                Console.WriteLine("Сколько этажей?");
                byte flooR = byte.Parse(Console.ReadLine());
                if (flooR <= 0)
                {
                    Console.WriteLine("Кол-во этажей не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Floor = flooR;
                }
                Console.WriteLine("Сколько квартир в доме?");
                byte apart_nuM = byte.Parse(Console.ReadLine());
                if (apart_nuM <= 0)
                {
                    Console.WriteLine("Кол-во квартир не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Apart_num = apart_nuM;
                }
                Console.WriteLine("А подъездов??");
                byte entrance_nuM = byte.Parse(Console.ReadLine());
                if (entrance_nuM <= 0)
                {
                    Console.WriteLine("Кол-во подъездов не может быть отрицательным");
                    Environment.Exit(0);
                }
                else
                {
                    Entrance_num = entrance_nuM;
                }
            }
            catch (DivideByZeroException)
            { Console.WriteLine("Вы ввели что-то не то"); }
            catch (FormatException)
            { Console.WriteLine("Вы ввели что-то не то"); }
        }
    }
}
