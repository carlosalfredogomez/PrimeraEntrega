using PrimeraEntrega.Handlers;
using PrimeraEntrega.Models;

namespace PrimeraEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Traer Usuario 
            Usuario usuario = UsuarioHandler.ObtenerUsuario(2);
            Console.WriteLine($"Usuario Id: {usuario.Id}, Usuario: {usuario.Nombre}");

            Console.WriteLine("   ");

            // Traer Productos
            List<Producto> productos = ProductoHandler.ObtenerProductos(1);
            foreach (var item in productos)
            {
                Console.WriteLine($"Productos cargados por el usuario {item.IdUsuario}: {item.Descripciones}");
            }

            Console.WriteLine("   ");
            Console.WriteLine(" Produtos vendidos ");

            // Traer Produtos vendidos
            List<Producto> productosVendidos = ProductoHandler.ObtenerProductoVendido(1);
            foreach (var item in productosVendidos)
            {
                Console.WriteLine($"Los Productos Vendidos por Usuario Id {item.IdUsuario}: {item.Descripciones}");
            }

            Console.WriteLine("    ");
            Console.WriteLine("  Ventas  ");

            // Traer Ventas 
            List<Venta> ventas = VentaHandler.ObtenerVentas(1);
            foreach (var item in ventas)
            {
                Console.WriteLine($"Ventas Usuario: {item.IdUsuario}, Id de la Venta: {item.Id}");
            }

            Console.WriteLine("   ");
            
            // Inicio de sesión 
            Usuario usuarioLogin = UsuarioHandler.ObtenerUsuarioLogin("eperez", "SoyErnestoPerez");
            Console.WriteLine($" Inicio de Sesión --- Usuario: {usuarioLogin.Nombre} \t  Apellido: {usuarioLogin.Apellido} \tMail: {usuarioLogin.Mail}");
           



        }
    }
}
