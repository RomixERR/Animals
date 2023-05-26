namespace Animls
{
    internal class Amphibian: Animal, iCategory
    {
        public Amphibian()
        {
            СategoryName = "Амфибия";
            СategoryDescription = "Позвоночное животное, дышащее в раннем возрасте жабрами, а во взрослом состоянии лёгкими.";
            СategoryAppointed = true;
        }
        public iCategory GetAnimal()
        {
            Amphibian animal = this;
            return animal;
        }
    }
}
