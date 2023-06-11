namespace Pizzeria.Model
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();

        public CanastaCompras Canasta { get; } = new CanastaCompras();

        public IU IU { get; set; } = new IU();

        public decimal PrecioTotal => Canasta.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
