﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal interface iAnimalCreator
    {
        iCategory Create(string SpeciesName, string SpeciesDescription = "");
    }
}
