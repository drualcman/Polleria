using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPolleria.Model;
using BlazingPolleria.Data;

namespace BlazingPolleria.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PolloStoreContext _db;

    public SpecialsController(PolloStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PolloSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}