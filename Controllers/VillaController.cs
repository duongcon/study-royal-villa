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
        public string GetVillaById(int id)
        {
            return $"Get Villa with ID: {id}";
        }

        [HttpGet("{id:int}/{name}")]
        public string GetVillaByIdAndName(int id, [FromRoute] string name)
        {
            return $"Get Villa with ID: {id} : {name}";
        }
    }
}
