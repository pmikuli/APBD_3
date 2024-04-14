using REST_api.Interfaces;
using REST_api.Models;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace REST_api.Repositories
{
    public class AnimalsRepository : IAnimalsRepository
    {
        private readonly string _connectionString = "server=db-mssql16.pjwstk.edu.pl\\\\sqlexpress;database=animals;trusted_connection=true;TrustServerCertificate=True";

        public IEnumerable<Animal> GetAllAnimals()
        {
            using SqlConnection con = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand();

            con.Open();

            SqlDataReader dr = command.ExecuteReader();

            List<Animal> animals = new List<Animal>();

            while (dr.Read())
            {
                Animal a = new Animal();
                a.Id = (int)dr["id"];
                a.Name = (string)dr["name"];
                a.Description = (string)dr["description"];
                a.Area = (string)dr["area"];
                a.Category = (string)dr["category"];
                animals.Add(a);
            }

            return animals;
        }

        public int CreateAnimal(Animal animal) 
        {
            using SqlConnection con = new SqlConnection(_connectionString);

            using SqlCommand command = new SqlCommand();
            command.Connection = con;

            command.CommandText = "INSERT INTO Animals(Name, Description, Area, Category) VALUES (@Name, @Description, @Area, @Category); SELECT SCOPE_IDENTITY;";
            command.Parameters.AddWithValue("@Name", animal.Name);

            con.Open();

            var id = (decimal)command.ExecuteScalar();

            return (int)id;
        }

        public int DeleteAnimal(int id)
        {
            // var affectedCount = command.executeNonQuery();
            throw new NotImplementedException();
        }
    }
}
