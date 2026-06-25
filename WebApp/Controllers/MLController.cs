using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Smart_Odoo.Models;
using Smart_Odoo.Service;

namespace Smart_Odoo.Controllers
{
    public class MLController : Controller
    {

        private readonly IMlService _service;
        private readonly IMemoryCache _cache;


        public MLController(
            IMlService service,
            IMemoryCache cache)
        {
            _service = service;
            _cache = cache;
        }



        public async Task<IActionResult> Index()
        {

            string cacheKey =
                "ML_Dashboard_Cache";


            if (!_cache.TryGetValue(cacheKey, out MlDashboardViewModel model))
            {

                model =
                    await _service.GetDashboardData();


                var options =
                    new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(
                        TimeSpan.FromMinutes(30)
                    );


                _cache.Set(
                    cacheKey,
                    model,
                    options
                );

            }


            return View(model);

        }






        [HttpPost]
        public async Task<IActionResult> SalesForecast(
            DateTime date)
        {

            var result =
                await _service
                .GetSalesForecast(date);


            return Json(result);

        }





        [HttpPost]
        public async Task<IActionResult> InventoryPrediction(
            [FromBody]
            InventoryMovementRequestModel model)
        {

            var result =
                await _service
                .PredictInventoryMovement(model);


            return Json(result);

        }



    }
}