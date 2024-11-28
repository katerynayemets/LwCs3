using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3.Factories
{
    public abstract class AbstractHouseFactory : IHouseFactory
    {
        public abstract IHouse CreateHouse();

        
        public string GetHouseInfo(IHouse house)
        {
            return $"Дім типу: {house.GetType().Name}, Площа: {house.CalculateArea()} м2, Вартість: {house.CalculateCost()} $";
        }
    }
}
