using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TecNET.Server.Data;
using TecNET.Shared.Models;

namespace TecNET.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuestionsDBContext _context;
        public QuestionsController(QuestionsDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var questions = await _context.Question.ToListAsync();
            return Ok(questions);
        }

        [HttpGet("category")]
        public async Task<IActionResult> GetCount(string category)
        {
            var questions = await _context.Question.Where(x=>x.Category.Contains(category)).ToListAsync();
            return Ok(questions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var questions = await _context.Question.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(questions);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Questions questions)
        {
            _context.Add(questions);
            await _context.SaveChangesAsync();
            return Ok(questions.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Questions questions)
        {
            _context.Entry(questions).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var questions = new Questions { Id = id };
            _context.Remove(questions);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
