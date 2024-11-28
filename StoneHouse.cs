using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public class StoneHouse : IHouse
    {
        private double baseArea; // Площадь одного этажа.
        private int floors; // Количество этажей.
        private double costPerSquareMeter = 1200; // Стоимость за квадратный метр.
        private double complexityMultiplier = 1.2; // Коэффициент сложности.
        private double materialWeightPerSquareMeter = 200; // Вес материала за квадратный метр.

        public StoneHouse(double baseArea, int floors, double complexityMultiplier = 1.2)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public void Build()
        {
            Console.WriteLine($"Будується кам'яний будинок з {floors} поверхами, площею {CalculateArea()} м².");
        }

        public double CalculateCost()
        {
            return CalculateArea() * costPerSquareMeter * complexityMultiplier;
        }

        public double CalculateArea()
        {
            return baseArea * floors;
        }

        public double CalculateBuildTime()
        {
            return floors * 3 * complexityMultiplier; // Пример: 3 недели на этаж с учетом сложности.
        }

        public double CalculateWeight()
        {
            return CalculateArea() * materialWeightPerSquareMeter;
        }
    }
}
