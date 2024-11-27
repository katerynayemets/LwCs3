using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarygg3
{
    public interface IHouse
    {
        /// <summary>
        /// Розрахувати вартість будівництва будинку.
        /// </summary>
        /// <returns>Вартість у грошовому вираженні.</returns>
        decimal CalculateCost();

        /// <summary>
        /// Розрахувати час будівництва будинку.
        /// </summary>
        /// <returns>Час у днях.</returns>
        int CalculateConstructionTime();

        /// <summary>
        /// Отримати площу будинку.
        /// </summary>
        /// <returns>Площа у квадратних метрах.</returns>
        double GetArea();
    }

}
