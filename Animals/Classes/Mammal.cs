using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal class Mammal : Animal, iСategory
    {
        public Mammal():base()
        {
            СategoryName = "Млекопитающее";
            СategoryDescription = "Класс позвоночных животных, основной отличительной особенностью которых является вскармливание детёнышей молоком.";
            СategoryAppointed = true;
        }
        public iСategory GetAnimal()
        {
            var animal = this;
            return animal;
        }
    }
}
