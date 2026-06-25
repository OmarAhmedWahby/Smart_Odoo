using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Smart_Odoo.Service;

namespace Smart_Odoo.Controllers
{
    [Authorize]
    public class SalesController : Controller
    {

        private readonly IDashboardSalesService _service;
        private readonly IMemoryCache _cache;

        public SalesController(IDashboardSalesService service , IMemoryCache cache)
        {
            _service = service;
            _cache = cache;
        }


        public async Task<IActionResult> Index()
        {
            string cacheKey = "Sales_Dashboard_Cache";

            if (!_cache.TryGetValue(cacheKey, out var model))
            {
                model = await _service.GetDashboardData();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
                    .SetPriority(CacheItemPriority.High);

                _cache.Set(cacheKey, model, cacheOptions);
            }

            return View(model);
        }
    }
}
