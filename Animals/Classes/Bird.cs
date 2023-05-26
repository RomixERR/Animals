namespace Animls
{
    internal class Bird : Animal, iCategory
    {
        public Bird()
        {
            СategoryName = "Птицы";
            СategoryDescription = "Группа теплокровных яйцекладущих позвоночных животных, традиционно рассматриваемая в ранге отдельного класса.";
            СategoryAppointed = true;
        }
        public iCategory GetAnimal()
        {
            Bird animal = this;
            return animal;
        }
    }
}
