using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam04.Business.Entities
{
    public class Plant
    {
        public int PlantID { get; set; }
        public string PlantNaam { get; set; }
        public string PlantSoort { get; set; }
        public decimal Prijs { get; set; }
        public string Season { get; set; }
        public string ImageNaam { get; set; }
        public Plant(string pNaam,string pSoort,decimal prijs,string season)
        {
            this.PlantNaam = pNaam;
            this.PlantSoort = pSoort;
            this.Prijs = prijs;
            this.Season = season;
        }

    }
}
