using IBBCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBCase.Business.Abstract
{
    public interface ICarParkService
    {
        Task<List<CarPark>> GetAll();
        Task<CarPark> GetById(int id);
        void Create(CarPark entity);
        void Update(CarPark entity);
        void Delete(CarPark entity);

    }
}
