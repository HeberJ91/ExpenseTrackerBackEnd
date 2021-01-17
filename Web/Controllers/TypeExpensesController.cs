using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Entities.TypeExpense;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeExpensesController : ControllerBase
    {
        private readonly DBContextSystem _context;

        public TypeExpensesController(DBContextSystem context)
        {
            _context = context;
        }

        // GET: api/TypeExpenses
        [HttpGet("[action]")]
        public async Task<IEnumerable<TypeExpenseModel>> GetAllTypes()
        {
            var typesexpense = await _context.TypesExpense.ToListAsync();

            return typesexpense.Select(t => new TypeExpenseModel
            {
                id = t.id,
                description = t.description,
                type = t.type,
                default_value = t.default_value,
                status = t.status
            });       
                
        }

        // GET: api/TypeExpenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeExpense>> GetTypeExpense(int id)
        {
            var typeExpense = await _context.TypesExpense.FindAsync(id);

            if (typeExpense == null)
            {
                return NotFound();
            }

            return typeExpense;
        }

        // PUT: api/TypeExpenses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeExpense(int id, TypeExpense typeExpense)
        {
            if (id != typeExpense.id)
            {
                return BadRequest();
            }

            _context.Entry(typeExpense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeExpenseExists(id))
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

        // POST: api/TypeExpenses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TypeExpense>> PostTypeExpense(TypeExpense typeExpense)
        {
            _context.TypesExpense.Add(typeExpense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeExpense", new { id = typeExpense.id }, typeExpense);
        }

        // DELETE: api/TypeExpenses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypeExpense>> DeleteTypeExpense(int id)
        {
            var typeExpense = await _context.TypesExpense.FindAsync(id);
            if (typeExpense == null)
            {
                return NotFound();
            }

            _context.TypesExpense.Remove(typeExpense);
            await _context.SaveChangesAsync();

            return typeExpense;
        }

        private bool TypeExpenseExists(int id)
        {
            return _context.TypesExpense.Any(e => e.id == id);
        }
    }
}
