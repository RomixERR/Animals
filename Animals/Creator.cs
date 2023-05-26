using System;

namespace Animls
{   /// <summary>
    /// УНИВЕРСАЛЬНАЯ
    /// Фабрика ТИПА
    /// Создаёт экземпляр заданного ТИПА
    /// </summary>
    internal class Creator: iAnimalCreatorT
        {/// <summary>
         /// Создаёт экземпляр
         /// </summary>
         /// <param name="SpeciesName">Название ВИДА</param>
         /// <param name="SpeciesDescription">Описание ВИДА</param>
         /// <returns></returns>
        public iCategory Create<T>(string SpeciesName, string SpeciesDescription="")
            where T : class, iCategory, new()
        {
            bool SpeciesAppointed = false;
            if (string.IsNullOrEmpty(SpeciesDescription)) {SpeciesDescription = "Нет описания вида";};
            if (string.IsNullOrEmpty(SpeciesName)) { SpeciesName = "--!КАТЕГОРИЯ НЕ НАЗВАНА!--";} else { SpeciesAppointed = true; };
            T animal = new T();
            animal.CreateNewAnimal(SpeciesName, SpeciesDescription);
            animal.SetSpeciesAppointed(SpeciesAppointed);
            return animal;
        }
    }
    
}
