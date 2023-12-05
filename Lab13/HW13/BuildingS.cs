using System;

namespace Lab13.HW13
{
    internal class BuildingS
    {
        private Building[] buildings;

        public BuildingS()
        {
            buildings = new Building[10];
        }
        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }

                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }

                buildings[index] = value;
            }
        }
    }
}
