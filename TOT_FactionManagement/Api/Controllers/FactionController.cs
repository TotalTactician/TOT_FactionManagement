using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactionController : ControllerBase
    {
        private readonly ILogger<FactionController> _logger;

        public FactionController(ILogger<FactionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFaction")]
        public IEnumerable<Faction> Get()
        {
            List<Faction> factionList = new List<Faction>();

            return factionList;
        }
    }
}