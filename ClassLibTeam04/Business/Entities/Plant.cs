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
        public string BestSeason { get; set; }
        public string ImageNaam { get; set; }
        public string imageFileName { get; set; }   
        public byte[] DataImage { get; set; }
        public Plant(string pNaam,string pSoort,decimal prijs,string season)
        {
            this.PlantNaam = pNaam;
            this.PlantSoort = pSoort;
            this.Prijs = prijs;
            this.BestSeason = season;
        }

    }
}
