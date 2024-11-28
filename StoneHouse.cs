using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public class StoneHouse : IHouse
    {
        private double baseArea; 
        private int floors; 
        private double costPerSquareMeter = 1200; 
        private double complexityMultiplier = 1.2; 

        public StoneHouse(double baseArea, int floors, double complexityMultiplier = 1.2)
        {
            this.baseArea = baseArea;
            this.floors = floors;
            this.complexityMultiplier = complexityMultiplier;
        }

        public StoneHouse() : this(100, 1) { } 

        public void Build()
        {
            Console.WriteLine($"Будується кам'яний будинок з {floors} поверхами, площею {CalculateArea()} м2.");
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
