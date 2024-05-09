using System.ComponentModel.DataAnnotations;

namespace WebApiTeamO4.viewModel
{
    public class PlantModel
    {
        public int PlantID { get; set; }
        [Required]
        public string PlantNaam { get; set; }
        [Required]
        public string PlantSoort { get; set; }
        [Required]
        public decimal Prijs { get; set; }
        [Required]
        public string Season { get; set; }
        public string ImageNaam { get; set; }

        public bool ValidSeason()
        {
            if (Season.ToLower().Contains("herft") || Season.ToLower().Contains("winter")|| Season.ToLower().Contains("lente")|| Season.ToLower().Contains("zomer"))
            {
                return true;
            }
            return false;
        }
    }
}
