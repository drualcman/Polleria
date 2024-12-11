using BlazingPolleria.Data;
using BlazingPolleria.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPolleria.Controllers;

[Route("toppings")]
[ApiController]
public class ToppingsController : Controller
{
    private readonly PolloStoreContext _db;

    public ToppingsController(PolloStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Topping>>> GetToppings()
    {
        return (await _db.Toppings.ToListAsync()).OrderByDescending(s => s.Price).ToList();
    }
}