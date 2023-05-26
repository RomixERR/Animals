using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal interface iDataSaver
    {
        void Save(DataBase dataBase, string fileName);
    }
}
