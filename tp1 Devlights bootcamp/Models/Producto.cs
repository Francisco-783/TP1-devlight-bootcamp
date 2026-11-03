namespace Kiosco_Devlights_bootcamp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Precio: ${Precio}, Categoría: {Categoria}, Activo: {Activo}";
        }
    }
}
