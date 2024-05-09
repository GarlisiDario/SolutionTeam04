using ClassLibTeam04.Business.Entities;
using ClassLibTeam04.Data.Framework;
using ClassLibTeam04.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam04.Business
{
    public static class Plantjes
    {
        public static IEnumerable<Plant> List()
        {
            return PlantRepository.PlantList;
        }
        public static InsertResult AddPlant(string naam, string soort,decimal prijs,string season,string image)
        {
            PlantRepository.Add(naam, prijs,soort,season);

            //TODO -> InsertResult
            PlantData plant = new PlantData();
            InsertResult result = plant.AddPlant(naam,soort,season,prijs,image);
            //InsertResult result=server.Insert(data ...);
            return result;
        }
        public static SelectResult GetPlant()
        {
            PlantData plant = new PlantData();
            SelectResult result = plant.GetPlant();
            return result;
        }


    }
}
