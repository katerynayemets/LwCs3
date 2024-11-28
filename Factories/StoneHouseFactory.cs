using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3.Factories
{
    public class StoneHouseFactory : AbstractHouseFactory
    {
        public override IHouse CreateHouse()
        {
            
            return new StoneHouse(120, 2);
        }
    }
}
