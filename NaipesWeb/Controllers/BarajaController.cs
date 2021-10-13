using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaipesWeb.Data;
using NaipesWeb.Models;

namespace NaipesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarajaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BarajaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Naipe>> GetBaraja()
        {

            var list = await _context.Naipes.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var baraja = list[index];

            if (baraja == null)
            {
                return NoContent();
            }

            return baraja;
        }

    }
}
