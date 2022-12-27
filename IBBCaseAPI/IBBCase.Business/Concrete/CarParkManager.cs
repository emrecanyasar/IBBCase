using IBBCase.Business.Abstract;
using IBBCase.Data.Abstract;
using IBBCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBCase.Business.Concrete
{
    public class CarParkManager : ICarParkService
    {
        public ICarParkRepository _carparkRepository;

        public CarParkManager(ICarParkRepository carparkRepository)
        {
            _carparkRepository = carparkRepository;
        }

        public void Create(CarPark entity)
        {
            _carparkRepository.Create(entity);
        }

        public void Delete(CarPark entity)
        {
           _carparkRepository.Delete(entity);
        }

        public async Task<List<CarPark>> GetAll()
        {
            return await _carparkRepository.GetAll();
        }

        public async Task<CarPark> GetById(int id)
        {
            return await _carparkRepository.GetById(id);
        }

        public void Update(CarPark entity)
        {
             _carparkRepository.Update(entity);
        }
    }
}
