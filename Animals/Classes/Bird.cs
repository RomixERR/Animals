namespace Animls
{
    internal class Bird : Animal, iСategory
    {
        public Bird()
        {
            СategoryName = "Птицы";
            СategoryDescription = "Группа теплокровных яйцекладущих позвоночных животных, традиционно рассматриваемая в ранге отдельного класса.";
            СategoryAppointed = true;
        }
        public iСategory GetAnimal()
        {
            Bird animal = this;
            return animal;
        }
    }
}
