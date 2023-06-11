namespace Pizzeria.Model
{
    public enum Especias
    {
        Ninguna,
        Condimentado,
        Picante
    }

    public class Pizza
    {
        public Pizza(int id, string nombre, decimal price,
        Especias especias)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = price;
            this.Especias = especias;
        }

        public int Id { get; }

        public string Nombre { get; }

        public decimal Precio { get; }

        public Especias Especias { get; }
    }

}

