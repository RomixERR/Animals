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
        public iСategory Create<T>(string SpeciesName, string SpeciesDescription="")
            where T : class, iСategory, new()
        {
            bool SpeciesAppointed = false;
            if (string.IsNullOrEmpty(SpeciesDescription)) {SpeciesDescription = "Нет описания типа";};
            if (string.IsNullOrEmpty(SpeciesName)) { SpeciesName = "--!КАТЕГОРИЯ НЕ НАЗВАНА!--";} else { SpeciesAppointed = true; };
            T animal = new T();
            animal.SetAnimal(SpeciesName, SpeciesDescription);
            animal.SetSpeciesAppointed(SpeciesAppointed);
            return animal;
        }
    }
    
}
