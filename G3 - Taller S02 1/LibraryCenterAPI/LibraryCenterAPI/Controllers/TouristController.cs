using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryCenterAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristController : ControllerBase
    {
        // GET: api/Tourist
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tourist/5
        [HttpGet("{id}", Name = "Get")]
        public Tourist Get(int id)
        {
            Tourist tourist = new Tourist();
            tourist.Id = id;
            // Llamar a la función de generación de turistas aleatorios
            Tourist generatedTourist = Tourist.GenerateRandomTourist();
            
            // Asignar los valores generados al turista creado
            tourist.Name = generatedTourist.Name;
            tourist.LastName = generatedTourist.LastName;
            tourist.Age = generatedTourist.Age;
            tourist.DNI = generatedTourist.DNI;

            return tourist;
        }

        // POST: api/Tourist
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tourist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tourist/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
