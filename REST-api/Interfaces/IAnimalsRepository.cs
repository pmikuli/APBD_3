using REST_api.Models;

namespace REST_api.Interfaces
{
    public interface IAnimalsRepository
    {
        IEnumerable<Animal> GetAllAnimals();

    }
}
