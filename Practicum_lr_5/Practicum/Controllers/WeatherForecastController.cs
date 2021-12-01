using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practicum.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicum.Controllers
{
    [ApiController]
    [Route("test")] //родительский

    public class WeatherForecastController : Controller
    {
        //запускается при старте
        [HttpPost]
        [HttpGet]
        [Produces("application/json")] 
        [Route("index")] //дочерний
        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "WebApplication was successfully launched" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")] // возвращаем json
        [Route("volume")]
        public async Task<IActionResult> Volume()
        {
            WebApplicationRequest request = new WebApplicationRequest(this.Request);

            double volume = request.A * request.B * request.C;

            MyClassResponse res = new MyClassResponse();
            res.Success = "success";
            res.Result = volume;
            res.Version = "1.2";
            return this.Json(res);
        }
    }
}
