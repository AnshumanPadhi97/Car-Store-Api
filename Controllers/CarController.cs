using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CARS_Api.Data;

namespace CARS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarsDataContext _context;

        public CarController(CarsDataContext context)
        {
            _context = context;
        }

        // GET: api/Car
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarsModel>>> GetCarsTable()
        {
            var data = await _context.CarsTable.ToListAsync();
            return Ok(data);
        }

        // GET: api/Car/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarsModel>> GetCarsModel([FromRoute] int id)
        {
            var carsModel = await _context.CarsTable.FindAsync(id);

            if (carsModel == null)
            {
                return NotFound();
            }

            return Ok(carsModel);
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarsModel([FromRoute] int id, [FromBody] CarsModel carsModel)
        {
            if (id != carsModel.car_id)
            {
                return BadRequest();
            }

            _context.Entry(carsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarsModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Car
        [HttpPost]
        public async Task<ActionResult<CarsModel>> PostCarsModel([FromBody] CarsModel carsModel)
        {
            _context.CarsTable.Add(carsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarsModel", new { id = carsModel.car_id }, carsModel);
        }

        // DELETE: api/Car/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarsModel(int id)
        {
            var carsModel = await _context.CarsTable.FindAsync(id);
            if (carsModel == null)
            {
                return NotFound();
            }

            _context.CarsTable.Remove(carsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarsModelExists(int id)
        {
            return _context.CarsTable.Any(e => e.car_id == id);
        }
    }
}
