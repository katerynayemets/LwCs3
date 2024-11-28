using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public class WoodenHouse : IHouse
    {
        private double baseArea;
        private int floors;
        private double costPerSquareMeter = 800;
        private double complexityMultiplier = 1.1;

        public WoodenHouse(double baseArea, int floors, double complexityMultiplier = 1.1)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public WoodenHouse() : this(80, 1) { } // Конструктор по умолчанию

        public void Build()
        {
            Console.WriteLine($"Будується дерев'яний будинок з {floors} поверхами, площею {CalculateArea()} м².");
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
