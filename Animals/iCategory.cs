using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal interface iCategory : iAnimal
    {   /// <summary>
        /// Имя данного класса
        /// </summary>
        string СategoryName { get;}
        /// <summary>
        /// Описание данного класса
        /// </summary>
        string СategoryDescription { get;}
        /// <summary>
        /// Получить экземпляр
        /// </summary>
        /// <returns></returns>
        iCategory GetAnimal();
        /// <summary>
        /// Установить экземпляр
        /// </summary>
        /// <param name="SpeciesName"></param>
        /// <param name="SpeciesDescription"></param>
    }
}
