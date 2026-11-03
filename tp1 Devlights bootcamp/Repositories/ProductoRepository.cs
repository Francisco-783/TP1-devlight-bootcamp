using Kiosco_Devlights_bootcamp.Models;

namespace Kiosco_Devlights_bootcamp.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> _productos;

        public ProductoRepository()
        {
            // Inicializar con datos de prueba
            _productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop Dell", Precio = 1200.50m, Categoria = "Electrónica", Activo = true },
                new Producto { Id = 2, Nombre = "Mouse Logitech", Precio = 45.99m, Categoria = "Accesorios", Activo = true },
                new Producto { Id = 3, Nombre = "Teclado Mecánico", Precio = 150.00m, Categoria = "Accesorios", Activo = true },
                new Producto { Id = 4, Nombre = "Monitor Samsung 27\"", Precio = 350.00m, Categoria = "Electrónica", Activo = false }
            };
        }

        public void Agregar(Producto producto)
        {
            if (producto != null)
            {
                _productos.Add(producto);
            }
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos;
        }

        public Producto ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
