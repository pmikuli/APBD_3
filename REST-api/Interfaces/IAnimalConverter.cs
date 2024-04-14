using REST_api.DTOs;
using REST_api.Models;

namespace REST_api.Interfaces
{
    public interface IAnimalConverter
    {
        AnimalDTO convert(Animal animal);
        Animal convert(AnimalCreationDTO animal);
    }
}
