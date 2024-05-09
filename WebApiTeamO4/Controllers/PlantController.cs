using ClassLibTeam04.Business;
using ClassLibTeam04.Business.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebApiTeamO4.viewModel;

namespace WebApiTeamO4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Plant>> GetPlant()
        {
            var getPlants = Plantjes.GetPlant();
            if (getPlants.Succeeded)
            {
                var plantTableResult = getPlants.DataTable;
                string JSONresult = JsonConvert.SerializeObject(plantTableResult);
                return Ok(JSONresult);
            }
            foreach (string error in getPlants.Errors)
                Debug.WriteLine(error);
            return BadRequest();
        }

        [HttpPost("AddPlant")]

        public async Task<ActionResult<Plant>> InsertPlant(PlantModel plant)
        {
            if (plant.ValidSeason())
            {
                var addPlant = Plantjes.AddPlant(plant.PlantNaam, plant.PlantSoort, plant.Prijs, plant.Season, plant.ImageNaam);
                if (addPlant.Succeeded)
                {
                    var nieuwPlant = addPlant.RowsAffected;
                    string JSONresult = JsonConvert.SerializeObject(nieuwPlant);
                    return Ok(JSONresult);
                }
                foreach (string error in addPlant.Errors)
                    Debug.WriteLine(error);
                return BadRequest();
            }
            else
            {
                return BadRequest("Ongeldige Season");
            }
           
           
        }
    }
}
