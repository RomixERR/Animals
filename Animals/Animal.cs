using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animls { 
    internal abstract class Animal : iAnimal
    {
        private static int LastID;

        public string СategoryName { get; protected set; }
        public string СategoryDescription { get; protected set; }
        public string SpeciesName { get; private set; }
        public string SpeciesDescription { get; private set; }
        public bool СategoryAppointed { get; protected set; }
        public bool SpeciesAppointed { get; protected set; }
        public int ID { get; private set; }

        public Animal()
        {
            СategoryAppointed = false;
            SpeciesAppointed = false;
        }
        public static void SetLastID(int ID)
        {
            LastID = ID;
        }

        public static int GetLastID()
        {
            return LastID;
        }


        public void CreateNewAnimal(string SpeciesName, string SpeciesDescription)
        {
            this.SpeciesName = SpeciesName;
            this.SpeciesDescription = SpeciesDescription;
            this.ID = LastID + 1;
            Animal.LastID = this.ID;
        }

        public void SetSpeciesAppointed(bool SpeciesAppointed = false)
        {
            this.SpeciesAppointed = SpeciesAppointed;
        }

        public override string ToString()
        {
            string cn, sn, sds;
            if (СategoryAppointed) cn = $"Категория = {СategoryName}"; else cn = $"{СategoryName}";
            if (SpeciesAppointed) sn = $"Вид = {SpeciesName}";  else sn = $"{SpeciesName}";
            if (!String.IsNullOrEmpty(SpeciesDescription)) sds = $", Описание вида = {SpeciesDescription}."; else sds = $".";

            string str = $"Animal. ID={ID}, {cn}, {sn}{sds}";
            return str;
        }
        


    }
}
