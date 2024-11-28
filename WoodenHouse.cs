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
        private double materialWeightPerSquareMeter = 100;

        public WoodenHouse(double baseArea, int floors, double complexityMultiplier = 1.1)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public void Build()
        {
            Console.WriteLine($"Будується дерев'яний будинок з {floors} поверхами, площею {CalculateArea()} м².");
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
            return floors * 2 * complexityMultiplier; // Быстрее, чем каменный дом.
        }

        public double CalculateWeight()
        {
            return CalculateArea() * materialWeightPerSquareMeter;
        }
    }
}
