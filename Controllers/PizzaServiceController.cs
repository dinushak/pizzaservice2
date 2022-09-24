using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaService.Data;
using System.Text;

namespace PizzaService.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaServiceController : ControllerBase
{

    private readonly DataContext _context;

    public PizzaServiceController(DataContext context)
    {
        //
        _context = context;
    }
    
    [HttpGet(Name = "GetPizzaOrders")]
    public async Task<ActionResult<List<PizzaOrder>>>  Get()
    {
        return Ok(await _context.PizzaOrders.ToListAsync());
    }
}
