using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3.Factories
{
    public class WoodenHouseFactory : AbstractHouseFactory
    {
        public override IHouse CreateHouse()
        {
            // Создаем деревянный дом с фиксированными параметрами
            return new WoodenHouse(80, 1);
        }
    }
}
