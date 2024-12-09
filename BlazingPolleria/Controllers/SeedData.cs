namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Pizza Básica de Queso",
                Description = "Es quesosa y deliciosa. ¿Por qué no querrías una?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "El Baconatorizador",
                Description = "Tiene TODO tipo de tocino",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Clásica de pepperoni",
                Description = "Es la pizza con la que creciste, ¡pero con un toque ardiente!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Pollo Buffalo",
                Description = "Pollo picante, salsa caliente y queso azul, garantizado para calentarte",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Amantes de los Champiñones",
                Description = "Tiene champiñones. ¿No es obvio?",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Delicia Vegetal",
                Description = "Es como ensalada, pero en una pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Pizza tradicional italiana con tomates y albahaca",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },

            new()
            {
               Id = 9,
               Name = "Margherita Tamaño Familiar",
               Description = "24\" de puro tomate y albahaca",
               BasePrice = 14.99m,
               ImageUrl = "img/pizzas/margherita.jpg",
               FixedSize = 24
            }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}

