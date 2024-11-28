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

        public GlassHouse(double baseArea, int floors, double complexityMultiplier = 1.5)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public GlassHouse() : this(100, 3) { } 

        public void Build()
        {
            Console.WriteLine($"Будується скляний будинок з {floors} поверхами, площею {CalculateArea()} м2.");
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
