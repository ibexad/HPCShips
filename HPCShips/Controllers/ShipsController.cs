using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HPCShips.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipsController : ControllerBase
    {        
        private readonly ILogger<ShipsController> _logger;

        public ShipsController(ILogger<ShipsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ship> Get()
        {
            var json = System.IO.File.ReadAllText(@"..\HPCShips\ships.json");
            var ships = JsonConvert.DeserializeObject<IEnumerable<Ship>>(json);

            return ships;
        }

        [HttpPost]
        public StatusCodeResult Post([FromBody] Ship data)
        {
            return new StatusCodeResult(201);
        }

        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] Ship data)
        {
            return new StatusCodeResult(200);
        }
        
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(int id)
        {
            return new StatusCodeResult(202);
        }
    }
}
