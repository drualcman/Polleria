using BlazingPolleria.Data;
using BlazingPolleria.Model;

namespace BlazingPolleria.Controllers;

public static class SeedData
{
    public static void Initialize(PolloStoreContext db)
    {
        var specials = new PolloSpecial[]
        {
            new PolloSpecial()
            {
                Name = "Cuarto de pollo",
                Description = "Crugientito y jugoso",
                BasePrice = 250.00m,
                ImageUrl = "img/pollos/cuarto-pollo.jpg",
            },
            new PolloSpecial()
            {
                Name = "Pollo entero",
                Description = "Lo mejor de lo mejor. Crugientito y jugoso",
                BasePrice = 1000.00m,
                ImageUrl = "img/pollos/entero-pollo.jpg",
            },
            new PolloSpecial()
            {
                Name = "Medio pollo",
                Description = "Crugientito y jugoso",
                BasePrice = 500.00m,
                ImageUrl = "img/pollos/medio-pollo.jpg",
            },
            new PolloSpecial()
            {
                Name = "Octavo de pollo",
                Description = "Un mata hamber. Crugientito y jugoso",
                BasePrice = 125.00m,
                ImageUrl = "img/pollos/octavo-pollo.jpg",
            }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}

