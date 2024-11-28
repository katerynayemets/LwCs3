using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public interface IHouse
    {
        void Build(); // Выводит процесс строительства.
        double CalculateCost(); // Рассчитывает стоимость дома.
        double CalculateArea(); // Рассчитывает общую площадь дома.
        double CalculateBuildTime(); // Рассчитывает время строительства.
        double CalculateWeight(); // Рассчитывает общий вес дома.
    }

}
