using PrimeraEntrega.Handlers;
using PrimeraEntrega.Models;

namespace PrimeraEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Traer Usuario (recibe un int) 
            Usuario usuario = UsuarioHandler.ObtenerUsuario(1);
            Console.WriteLine($"Usuario Id: {usuario.Id}, Usuario: {usuario.Nombre} {usuario.Apellido}");

            Console.WriteLine("   ");

            // Traer Productos (recibe id de usuario, devuelve lista)
            List<Producto> productos = ProductoHandler.ObtenerProductos(1);
            foreach (var item in productos)
            {
                Console.WriteLine($"Productos cargados por el usuario {item.IdUsuario}: {item.Descripciones}");
            }

            Console.WriteLine("   ");
            Console.WriteLine(" Produtos vendidos ");

            // Traer Produtos vendidos (recibe id de usuario, devuelve lista)
            List<Producto> productosVendidos = ProductoHandler.ObtenerProductoVendido(1);
            foreach (var item in productosVendidos)
            {
                Console.WriteLine($"Los Productos Vendidos por Usuario Id {item.IdUsuario}: {item.Descripciones}");
            }

            Console.WriteLine("    ");
            Console.WriteLine("  Ventas  ");

            // Traer Ventas  (recibe id de usuario, devuelve lista)
            List<Venta> ventas = VentaHandler.ObtenerVentas(1);
            foreach (var item in ventas)
            {
                Console.WriteLine($"Ventas Usuario: {item.IdUsuario}, Id de la Venta: {item.Id}");
            }

            Console.WriteLine("   ");
            
            // Inicio de sesión (recibe usuario y contraseña, devuelve objeto usuario)
            Usuario usuarioLogin = UsuarioHandler.ObtenerUsuarioLogin("tcasazza", "SoyTobiasCasazza");
            Console.WriteLine($" Inicio de Sesión --- Usuario: {usuarioLogin.Nombre} \t  Apellido: {usuarioLogin.Apellido} \tMail: {usuarioLogin.Mail}");
           



        }
    }
}
