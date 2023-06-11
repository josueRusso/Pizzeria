using System.Text.Json;

namespace Pizzeria.Model.Clientes
{
    public static class ExtensionDepuracion
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions{ WriteIndented = true };

        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);

    }
}
