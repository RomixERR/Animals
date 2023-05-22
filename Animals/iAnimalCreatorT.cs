using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal interface iAnimalCreatorT
    {
        iСategory Create<T>(string SpeciesName, string SpeciesDescription = "")
              where T : class, iСategory, new();
    }
}
