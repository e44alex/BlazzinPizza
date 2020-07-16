using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }
        public Pizza ConfiguringPizza { get; private set; }
        public Order Order { get; private set; }= new Order();


        void ShowConfigureDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>()
            };

            ShowingConfigureDialog = true;
        }

        void CancelConfigurePizzaDialog()
        {
            ConfiguringPizza  = null;
            ShowingConfigureDialog = false;
        }

        void ConfirmConfigurePizzaDialog()
        {
            Order.Pizzas.Add(ConfiguringPizza);
            ConfiguringPizza = null;

            ShowingConfigureDialog = false;
        }

        void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

    }
}