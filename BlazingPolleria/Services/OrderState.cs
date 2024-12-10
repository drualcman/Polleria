using BlazingPolleria.Model;

namespace BlazingPolleria.Services;

public class OrderState
{
    public bool ShowingConfigureDialog { get; private set; }
    public Pollo ConfiguringPizza { get; private set; }
    public Order Order { get; private set; } = new Order();

    public void ShowConfigurePizzaDialog(PolloSpecial special)
    {
        ConfiguringPizza = new Pollo()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pollo.DefaultSize,
            Toppings = new List<PolloTopping>(),
        };

        ShowingConfigureDialog = true;
    }

    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    public void ConfirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    public void RemoveConfiguredPizza(Pollo pizza)
    {
        Order.Pizzas.Remove(pizza);
    }
    public void ResetOrder()
    {
        Order = new Order();
    }

}