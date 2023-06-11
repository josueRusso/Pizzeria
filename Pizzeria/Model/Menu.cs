using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.Model
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public void Add(Pizza pizza) => Pizzas.Add(pizza);

        public Pizza? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
