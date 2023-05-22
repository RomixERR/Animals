namespace Animls
{
    internal class Amphibian: Animal, iСategory
    {
        public Amphibian()
        {
            СategoryName = "Амфибия";
            СategoryDescription = "Позвоночное животное, дышащее в раннем возрасте жабрами, а во взрослом состоянии лёгкими.";
            СategoryAppointed = true;
        }
        public iСategory GetAnimal()
        {
            Amphibian animal = this;
            return animal;
        }
    }
}
