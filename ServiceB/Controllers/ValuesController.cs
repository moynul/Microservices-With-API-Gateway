using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ServiceBModel> Get()
        {
            return new[]
            {
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Why Azure?", Body = "..." },
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Docker is Awesome", Body = "..." },
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Kubernetes is Amazing", Body = "..." }

            };
        }
    }
    public class ServiceBModel
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
