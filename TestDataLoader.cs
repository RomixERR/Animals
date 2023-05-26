using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal class TestDataLoader : iDataLoader
    {
        public void Load(DataBase dataBase, string fileName)
        {
            iAnimalCreatorT aa = new Creator();
            Animal.SetLastID(0);
            var frog = aa.Create<Amphibian>("Лямгущьк");
            var cow = aa.Create<Mammal>("Коровка", "Пасётся на вольном выгоне");
            var cat = aa.Create<Mammal>("Котяра");
            var solovey = aa.Create<Bird>("Соловушка","Красиво поёт по ночам");

            List<iCategory> animals = new List<iCategory>();

            animals.Add(cat);
            animals.Add(frog);
            animals.Add(cow);
            animals.Add(solovey);

            dataBase.Animals = animals;

        }
    }
}
