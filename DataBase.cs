using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls
{
    internal class DataBase
    {
        public List<iCategory> Animals { get; set;}

        public DataBase()
        {
            
        }

        public void SaveData(iDataSaver dataSaver, string fileName)
        {
            dataSaver.Save(this, fileName);
        }

        public void LoadData(iDataLoader dataLoader,string fileName)
        {
            dataLoader.Load(this, fileName);
        }

        public int GetLastID()
        {
             return Animal.GetLastID();
        }

        public override string ToString()
        {
            string str="";
            const int MAXSIGNS = 10;
            int cnt;

            if (Animals.Count<= MAXSIGNS) cnt = Animals.Count; else cnt = MAXSIGNS;

            for (int i = 0; i < cnt; i++)
            {
                str += Animals[i].ToString() + "\n";
            }

            return str;
        }



    }
}
