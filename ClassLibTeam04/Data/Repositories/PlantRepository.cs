using ClassLibTeam04.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam04.Data.Repositories
{
    internal class PlantRepository
    {
        static PlantRepository()
        {
            PlantList = new List<Plant>();
        }
        public static List<Plant> PlantList
        {
            get;
            set;

        }
        public static void Add(string naam, decimal prijs,string soort,string season)
        {
            Plant plant = new Plant(naam, soort,prijs,season);
            plant.PlantID = GetId();
            Add(plant);
        }
        private static int GetId()
        {
            int id = 1;
            if (PlantList.Count > 0) id = PlantList.Max(x => x.PlantID) + 1;
            return id;
        }
        private static void Add(Plant user)
        {
            PlantList.Add(user);
        }
    }
}
