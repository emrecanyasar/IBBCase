using IBBCaseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace IBBCaseMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var carPark = new List<CarPark>();
            using (var httpClint = new HttpClient())
            {
                using (var response = await httpClint.GetAsync("https://localhost:7269/CarPark/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    carPark = JsonConvert.DeserializeObject<List<CarPark>>(apiResponse);
                }
            }

            var res = new Response();
            using (var httpClint = new HttpClient())
            {
                using (var response = await httpClint.GetAsync("https://data.ibb.gov.tr/api/3/action/datastore_search?resource_id=f4f56e58-5210-4f17-b852-effe356a890c&limit=708"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<Response>(apiResponse);
                }
            }
            var allCarPark = new List<AllCarPark>();
            allCarPark = res.result.records;


            var cPark = new AllCarParkViewModel()
            {
                AllCarPark = allCarPark.Where(a=>!carPark.Any(b=>b._id==a._id)).ToList(),
                MyCarPark = carPark
            };


            return View(cPark);

        }
        public async Task<IActionResult> GetCarPark()
        {
            var carPark = new List<CarPark>();
            using (var httpClint = new HttpClient())
            {
                using (var response=await httpClint.GetAsync("https://localhost:7269/CarPark/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    carPark=JsonConvert.DeserializeObject<List<CarPark>>(apiResponse);
                }
            }
            return View(carPark);
        }

        public IActionResult AddMyCarPark()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMyCarPark(AllCarPark allCarPark)
        {
            var carPark = new List<CarPark>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7269");
                var postCarPark = client.PostAsJsonAsync<AllCarPark>("/CarPark/CreateCarPark", allCarPark);
                postCarPark.Wait();

                var postResult = postCarPark.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MyCarParkUpdate(int id)
        {
            var carPark = new CarPark();
            using (var httpClint = new HttpClient())
            {
                using (var response = await httpClint.GetAsync("https://localhost:7269/CarPark/GetCarParkById/" + id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    carPark = JsonConvert.DeserializeObject<CarPark>(apiResponse);
                }
            }
            return View(carPark);
        }

        [HttpPost]
        public async Task<IActionResult> MyCarParkUpdate(CarPark carPark)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7269");
                var putCarPark = client.PutAsJsonAsync<CarPark>("/CarPark/UpdateCarPark", carPark);
                putCarPark.Wait();

                var putResult = putCarPark.Result;
                if (putResult.IsSuccessStatusCode)
                    return RedirectToAction("GetCarPark");
            }
            return RedirectToAction("GetCarPark");
        }
        public IActionResult MyCarParkDelete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7269");
                var deleteCarPark = client.DeleteAsync("/CarPark/DeleteCarPark?carParkId=" + id.ToString());
                var result=deleteCarPark.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetCarPark");
                }
            }
                    return RedirectToAction("GetCarPark");
        }

    }
}