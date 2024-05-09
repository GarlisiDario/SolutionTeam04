using ClassLibTeam04.Data.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam04
{
    internal class PlantData : SqlServer
    {
        public PlantData() 
        {
            TableName = "Plantjes";
        }
        public string TableName { get; set; }
        public SelectResult GetPlant()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"Select * from {TableName} ";
            return base.Select(command);
        }
        public InsertResult AddPlant(string naam,string soort,string season,decimal prijs,string image)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into {TableName} (PlantNaam,PlantSoort,Prijs,BestSeason,imageNaam) " +
                $"values (@PlantNaam,@PlantSoort, @Prijs, @BestSeason,@Image)";
            command.Parameters.AddWithValue("@PlantSoort",soort);
            command.Parameters.AddWithValue("@BestSeason", season);
            command.Parameters.AddWithValue("@Prijs", prijs);
            command.Parameters.AddWithValue("@PlantNaam", naam);
            command.Parameters.AddWithValue("@Image", image);
            return base.Insert(command);

        }

    }
}
