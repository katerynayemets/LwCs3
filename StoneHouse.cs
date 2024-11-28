using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public class StoneHouse : IHouse
    {
        private double baseArea; // Площадь одного этажа
        private int floors; // Количество этажей
        private double costPerSquareMeter = 1200; // Стоимость за квадратный метр
        private double complexityMultiplier = 1.2; // Коэффициент сложности

        public StoneHouse(double baseArea, int floors, double complexityMultiplier = 1.2)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public StoneHouse() : this(100, 1) { } // Конструктор по умолчанию

        public void Build()
        {
            Console.WriteLine($"Строится каменный дом с {floors} этажами, площадью {CalculateArea()} м².");
        }

        public double CalculateCost()
        {
            return baseArea * floors * costPerSquareMeter * complexityMultiplier;
        }

        public double CalculateArea()
        {
            return baseArea * floors;
        }

        public double CalculateBuildTime()
        {
            throw new NotImplementedException();
        }

        public double CalculateWeight()
        {
            throw new NotImplementedException();
        }
    }

}
