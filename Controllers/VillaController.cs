using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalVilla_API.Data;
using RoyalVilla_API.Models;

namespace RoyalVilla_API.Controllers
{
    [Route("api/villa")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public VillaController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Villa>>> GetVillas()
        {
            return Ok(await _dbContext.Villa.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Villa>> GetVillaById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID. ID must be greater than zero.");
                }
                else
                {
                    var villa = await _dbContext.Villa.FirstOrDefaultAsync(u => u.Id == Convert.ToString(id));
                    if (villa == null)
                    {
                        return NotFound($"Villa with ID {id} not found.");
                    }
                    return Ok(villa);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id:int}/{name}")]
        public string GetVillaByIdAndName(int id, [FromRoute] string name)
        {
            try
            {
                return $"Get Villa with ID: {id} and Name: {name}";

            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
