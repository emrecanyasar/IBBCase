using IBBCase.Data.Abstract;
using IBBCase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBCase.Data.Concrete
{
    public class CarParkRepository : ICarParkRepository
    {
        //public CarParkRepository(IBBCaseDbContext _dbContext) : base(_dbContext)
        //{

        //}
        //public IBBCaseDbContext ibbcaseDbContext
        //{
        //    get
        //    {
        //        return _dbContext as IBBCaseDbContext;
        //    }
        //}

        //public async Task<List<CarPark>> GetCarsByUserId(string userId)
        //{
        //    List<CarPark> cars = new List<CarPark>();
        //    cars = ibbcaseDbContext.CarParks
        //        .Where(x=>x.AppUserId==userId).ToList();
        //    return cars;
        //}
        public void Create(CarPark entity)
        {
            using (var context = new IBBCaseDbContext())
            {
                context.CarParks.Add(entity);
                context.SaveChanges();
            } 
        }
        public void Delete(CarPark entity)
        {

            using (var context = new IBBCaseDbContext())
            {
                context.CarParks.Remove(entity);
                context.SaveChanges();
            }
        }

        public async Task<List<CarPark>> GetAll()
        {
            using (var context = new IBBCaseDbContext())
            {
                return await context.CarParks.ToListAsync();
            }
        }

        public async Task<CarPark> GetById(int id)
        {
            using (var context = new IBBCaseDbContext())
            {
                return await context.CarParks.FindAsync(id);
            }
        }

        public void Update(CarPark entity)
        {
            using (var context = new IBBCaseDbContext())
            {
                 context.CarParks.Update(entity);
                context.SaveChanges();
            } 
        }
    }
}
