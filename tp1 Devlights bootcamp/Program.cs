using Kiosco_Devlights_bootcamp.Models;
using Kiosco_Devlights_bootcamp.Repositories;

// Instanciar el repositorio
IProductoRepository repo = new ProductoRepository();

Console.WriteLine("========== GESTIÓN DE PRODUCTOS ==========\n");

// Imprimir lista completa
Console.WriteLine("1. LISTA COMPLETA DE PRODUCTOS:");
Console.WriteLine("--------------------------------");
var productos = repo.ObtenerTodos();
foreach (var producto in productos)
{
    Console.WriteLine(producto);
}

Console.WriteLine("\n");

// Busqueda por ID
Console.WriteLine("2. BÚSQUEDA DE PRODUCTO POR ID (ID = 2):");
Console.WriteLine("----------------------------------------");
var productoPorId = repo.ObtenerPorId(2);
if (productoPorId != null)
{
    Console.WriteLine(productoPorId);
}
else
{
    Console.WriteLine("Producto no encontrado");
}

Console.WriteLine("\n");

// Filtrado por categoría
Console.WriteLine("3. FILTRADO DE PRODUCTOS POR CATEGORÍA (Electrónica):");
Console.WriteLine("-----------------------------------------------------");
var productosPorCategoria = repo.BuscarPorCategoria("Electrónica");
foreach (var producto in productosPorCategoria)
{
    Console.WriteLine(producto);
}

Console.WriteLine("\n");

// Agregar nuev producto
Console.WriteLine("4. AGREGANDO NUEVO PRODUCTO:");
Console.WriteLine("----------------------------");
var nuevoProducto = new Producto
{
    Id = 5,
    Nombre = "Webcam HD",
    Precio = 89.99m,
    Categoria = "Accesorios",
    Activo = true
};
repo.Agregar(nuevoProducto);
Console.WriteLine($"Producto agregado: {nuevoProducto}");

Console.WriteLine("\n");

// Mostrar lista actualizada
Console.WriteLine("5. LISTA COMPLETA ACTUALIZADA:");
Console.WriteLine("------------------------------");
var productosActualizados = repo.ObtenerTodos();
foreach (var producto in productosActualizados)
{
    Console.WriteLine(producto);
}

Console.WriteLine("\n¡Prueba completada!");
