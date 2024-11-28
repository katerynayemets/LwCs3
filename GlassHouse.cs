using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public class GlassHouse : IHouse
    {
        private double baseArea;
        private int floors;
        private double costPerSquareMeter = 1500;
        private double complexityMultiplier = 1.5;
        private double materialWeightPerSquareMeter = 50;

        public GlassHouse(double baseArea, int floors, double complexityMultiplier = 1.5)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public void Build()
        {
            Console.WriteLine($"Будується скляний будинок з {floors} поверхами, площею {CalculateArea()} м².");
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
            return floors * 4 * complexityMultiplier; // Дольше, чем каменный и деревянный дома.
        }

        public double CalculateWeight()
        {
            return CalculateArea() * materialWeightPerSquareMeter;
        }
    }
}
