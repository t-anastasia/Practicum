using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            return this.Json(new { result = "Hello World!" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")] // возвращаем json
        [Route("hello_world")]
        public async Task<IActionResult> Test()
        {
            MyClassResponse res = new MyClassResponse();
            res.Success = "success";
            res.Result = "hello_world";
            res.Version = "1.1";
            return this.Json(res);
        }
    }
}
