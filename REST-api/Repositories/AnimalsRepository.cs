using REST_api.Interfaces;
using REST_api.Models;
using System.Data.SqlClient;

namespace REST_api.Repositories
{
    public class AnimalsRepository : IAnimalsRepository
    {

        public IEnumerable<Animal> GetAllANimals()
        {
            using SqlConnection con = new SqlConnection("\"server=db-mssql16.pjwstk.edu.pl\\\\sqlexpress;database=animals;trusted_connection=true;TrustServerCertificate=True\"");

        }

    }
}
