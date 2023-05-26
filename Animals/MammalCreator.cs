namespace Animls
{   /// <summary>
    /// Фабрика ТИПА
    /// Создаёт экземпляр заданного ТИПА
    /// </summary>
    internal class MammalCreator: iAnimalCreator
        {/// <summary>
         /// Создаёт экземпляр
         /// </summary>
         /// <param name="SpeciesName">Название ВИДА</param>
         /// <param name="SpeciesDescription">Описание ВИДА</param>
         /// <returns></returns>
        public iCategory Create(string SpeciesName, string SpeciesDescription="")
        {
            bool SpeciesAppointed = false;
            if (string.IsNullOrEmpty(SpeciesDescription)) {SpeciesDescription = "Нет описания типа";};
            if (string.IsNullOrEmpty(SpeciesName)) { SpeciesName = "--!КАТЕГОРИЯ НЕ НАЗВАНА!--";} else { SpeciesAppointed = true; };
            Mammal animal = new Mammal();
            animal.CreateNewAnimal(SpeciesName, SpeciesDescription);
            animal.SetSpeciesAppointed(SpeciesAppointed);
            return animal;
        }
    }
    
}
