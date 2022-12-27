using IBBCase.Business.Abstract;
using IBBCase.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IBBCase.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarParkController : ControllerBase
    {
        public ICarParkService _carParkService;

        public CarParkController(ICarParkService carParkService)
        {
            _carParkService = carParkService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var carPark = await _carParkService.GetAll();
            return Ok(carPark);
        }
        [HttpGet]
        [Route("[action]/{carParkId}")]
        public async Task<IActionResult> GetCarParkById(int carParkId)
        {
            var carPark = await _carParkService.GetById(carParkId);
            return Ok(carPark);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCarPark(CarPark entity)
        {
             _carParkService.Update(entity);
            return Ok(entity);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCarPark(CarPark entity)
        {
             _carParkService.Create(entity);
            return Ok(entity);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteCarPark(int carParkId)
        {
            CarPark carPark = await _carParkService.GetById(carParkId);
            _carParkService.Delete(carPark);
            return Ok(carPark);
        }
    }
}
