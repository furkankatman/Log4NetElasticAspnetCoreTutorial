using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Log4NetElasticAspnetCoreTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger)
        {
            
            this._logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Company(int id)
        {
            _logger.LogInformation(string.Format("#####Company Controller's httpget method is called#####"));
            var companys =new string[]{"DEFACTO","DEFACTO TEKNOLOJİ","Koç","Arçelik","Beko","Vestel","Empolka Metal" };
            _logger.LogInformation(string.Format("#####Company Controller's httpget method returned {0}#####", JsonConvert.SerializeObject(companys)));
            return Ok(JsonConvert.SerializeObject(companys));
        }
    }
}
