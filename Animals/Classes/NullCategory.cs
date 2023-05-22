namespace Animls
{
    internal class NullCategory : Animal, iСategory
    {
        public NullCategory()
        {
            СategoryName = "-!НЕ СУЩЕСТВУЕТ!-";
            СategoryDescription = "-!ТАКОГО КЛАССА НЕ СУЩЕСТВУЕТ!-";
        }

        public iСategory GetAnimal()
        {
            NullCategory animal = this;
            return animal;
        }

    }
}
