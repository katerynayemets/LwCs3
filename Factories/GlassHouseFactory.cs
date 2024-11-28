using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3.Factories
{
    public class GlassHouseFactory : AbstractHouseFactory
    {
        public override IHouse CreateHouse()
        {
            
            return new GlassHouse(100, 3);
        }
    }
}
