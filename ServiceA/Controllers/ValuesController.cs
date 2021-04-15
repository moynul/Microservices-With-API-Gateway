using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ServiceAModel> Get()
        {
            return new[]
            {
                new ServiceAModel{Name = "Google",Url = "https://www.google.com.au"},
                new ServiceAModel{Name = "SSW",Url = "https://www.ssw.com.au"},
                new ServiceAModel{Name = "eBay",Url = "https://www.ebay.com.au/"},
            };
        }

        public class ServiceAModel
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}
