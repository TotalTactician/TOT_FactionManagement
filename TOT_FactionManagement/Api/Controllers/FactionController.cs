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

        [HttpGet(Name = "GetFactions")]
        public IEnumerable<Faction> Get()
        {
            List<Faction> factionList = new List<Faction>();

            factionList.Add(new(1, "a"));
            factionList.Add(new(2, "b"));
            factionList.Add(new(3, "c"));

            return factionList;
        }
    }
}