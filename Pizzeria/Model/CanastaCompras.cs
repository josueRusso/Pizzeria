using System.Collections.Generic;

namespace Pizzeria.Model
{
    public class CanastaCompras
    {
        public Cliente Cliente { get; set; } = new Cliente();

        public List<int> Pedidos { get; set; } = new List<int>();

        public bool Cuenta { get; set; }

        public void Add(int pizzaId) => Pedidos.Add(pizzaId);

        public void RemoveAt(int pos) => Pedidos.RemoveAt(pos);
    }
}
