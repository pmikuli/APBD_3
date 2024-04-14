using REST_api.DTOs;
using REST_api.Interfaces;
using REST_api.Models;

namespace REST_api.Services
{
    public class AnimalsService : IAnimalsService
    {
        private IAnimalsRepository _animalsRepository;
        public AnimalsService(IAnimalsRepository animalsRepository)
        {
            _animalsRepository = animalsRepository;
        }

        public void CreateAnimal(AnimalCreationDTO animal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnimalDTO> GetAllAnimals()
        {
            var animalsFromRepo = _animalsRepository.GetAllAnimals();

            // TODO convert 

            throw new NotImplementedException();
        }
    }
}
