using REST_api.DTOs;
using REST_api.Models;

namespace REST_api.Interfaces
{
    public interface IAnimalsService
    {
        IEnumerable<AnimalDTO> GetAllAnimals();

        void CreateAnimal(AnimalCreationDTO animal);
    }
}
