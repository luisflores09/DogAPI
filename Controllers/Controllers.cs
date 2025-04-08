using DogAPI.Data;
using DogAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly DogDbContext _context;

        public DogsController(DogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dog>>> GetDogs()
        {
            return await _context.Dogs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dog>> GetDog(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null) return NotFound();
            return dog;
        }

        [HttpPost]
        public async Task<ActionResult<Dog>> CreateDog(Dog dog)
        {
            _context.Dogs.Add(dog);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDog), new { id = dog.Id }, dog);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDog(int id, Dog dog)
        {
            if (id != dog.Id) return BadRequest();
            _context.Entry(dog).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDog(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null) return NotFound();
            _context.Dogs.Remove(dog);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}