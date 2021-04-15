
using Elastic.ApplicationServices.Definitions.Querys;
using Elastic.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elastic.API.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class ElasticsearchController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ElasticsearchController> _logger;
        private readonly IElasticsearchQuerys _ElasticsearchQuerys;
        public ElasticsearchController(IConfiguration configuration, ILogger<ElasticsearchController> logger, IElasticsearchQuerys elasticsearchQuerys)
        {
            _configuration = configuration;
            _logger = logger;
            _ElasticsearchQuerys = elasticsearchQuerys;
        }
        // GET: ElasticsearchController
        public string Index()
        {
            return "API Search";
        }

        [HttpPost]
        public async Task<IActionResult> Search(Search search)
        {
            return Ok(await Task.Run(() => _ElasticsearchQuerys.Search(search)));
        }
    }
}
