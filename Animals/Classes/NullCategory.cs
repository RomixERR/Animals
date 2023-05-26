namespace Animls
{
    internal class NullCategory : Animal, iCategory
    {
        public NullCategory()
        {
            СategoryName = "-!НЕ СУЩЕСТВУЕТ!-";
            СategoryDescription = "-!ТАКОГО КЛАССА НЕ СУЩЕСТВУЕТ!-";
        }

        public iCategory GetAnimal()
        {
            NullCategory animal = this;
            return animal;
        }

    }
}
