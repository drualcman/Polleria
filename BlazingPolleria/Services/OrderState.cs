using BlazingPolleria.Model;

namespace BlazingPolleria.Services;

public class OrderState
{
    public bool ShowingConfigureDialog { get; private set; }
    public Pollo ConfiguringPollo { get; private set; }
    public Order Order { get; private set; } = new Order();

    public void ShowConfigurePizzaDialog(PolloSpecial special)
    {
        ConfiguringPollo = new Pollo()
        {
            Special = special,
            SpecialId = special.Id,
            Toppings = new List<PolloTopping>(),
        };

        ShowingConfigureDialog = true;
    }

    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPollo = null;

        ShowingConfigureDialog = false;
    }

    public void ConfirmConfigurePolloDialog()
    {
        Order.Pollos.Add(ConfiguringPollo);
        ConfiguringPollo = null;

        ShowingConfigureDialog = false;
    }

    public void RemoveConfiguredPollo(Pollo pizza)
    {
        Order.Pollos.Remove(pizza);
    }
    public void ResetOrder()
    {
        Order = new Order();
    }

}