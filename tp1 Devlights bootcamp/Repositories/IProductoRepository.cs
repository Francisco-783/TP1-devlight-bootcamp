using Kiosco_Devlights_bootcamp.Models;

namespace Kiosco_Devlights_bootcamp.Repositories
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
