namespace Animls
{
    internal class Mammal : Animal, iCategory
    {
        public Mammal():base()
        {
            СategoryName = "Млекопитающее";
            СategoryDescription = "Класс позвоночных животных, основной отличительной особенностью которых является вскармливание детёнышей молоком.";
            СategoryAppointed = true;
        }
        public iCategory GetAnimal()
        {
            var animal = this;
            return animal;
        }
    }
}
