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

        // Базовая логика (общая для всех фабрик)
        public string GetHouseInfo(IHouse house)
        {
            return $"Дом типа: {house.GetType().Name}, Площадь: {house.CalculateArea()} м², Стоимость: {house.CalculateCost()} $";
        }
    }
}
