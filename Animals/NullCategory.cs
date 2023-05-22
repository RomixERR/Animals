using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
