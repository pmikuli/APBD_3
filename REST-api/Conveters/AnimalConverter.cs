using REST_api.DTOs;
using REST_api.Interfaces;
using REST_api.Models;

namespace REST_api.Validators
{
    public class AnimalConverter : IAnimalConverter
    {
        public AnimalDTO convert(Animal animal)
        {
            AnimalDTO a = new AnimalDTO();
            throw new NotImplementedException();
        }

        public Animal convert(AnimalCreationDTO animal)
        {
            throw new NotImplementedException();
        }
    }
}
