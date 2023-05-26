using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal interface iAnimal
    {
        /// <summary>
        /// Название вида
        /// </summary>
        string SpeciesName { get; }
        /// <summary>
        /// Описание
        /// </summary>
        string SpeciesDescription { get; }
        /// <summary>
        /// Сategory не определен
        /// </summary>
        bool СategoryAppointed { get; }
        /// <summary>
        /// Вид не определен
        /// </summary>
        bool SpeciesAppointed { get; }
        /// <summary>
        /// задать вид животного
        /// </summary>
        /// <param name="SpeciesName">Название вида</param>
        /// <param name="SpeciesDescription">Описание вида</param>
        void CreateNewAnimal(string SpeciesName, string SpeciesDescription);
        void SetSpeciesAppointed(bool SpeciesAppointed);
        int ID { get; }
        string ToString();
    }
}
