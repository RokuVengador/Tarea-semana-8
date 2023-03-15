using Semana8.Models;
Console.WriteLine("Bienvenido a tu BD favorita.");
Console.WriteLine("Ingresa los siguientes datos.");

#region isertar tus datos
//para ingresar datos a la BD
using (AlmacenContext db = new
    AlmacenContext()) {

    Producto producto = new Producto();

    Console.WriteLine("Ingresa tu nombre: ");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("Decribe el articulo: ");
    producto.Descripción = Console.ReadLine();

    Console.WriteLine("Ingresa su precio: ");
    producto.Precio = float.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa numero de stock: ");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("=======================================================================");
    Console.WriteLine("...Por favor espere mientras se cargan sus datos a la base de datos...");

    db.Productos.Add(producto);
    db.SaveChanges();

    var ListProductos = db.Productos.ToList();
    foreach (var prod in ListProductos)
    {
        
        Console.WriteLine("Sus datos ingresados son: \n");
        Console.WriteLine("Nombre: " + prod.Nombre);
        Console.WriteLine("Descripción: " + prod.Descripción);
        Console.WriteLine("Precio: " + prod.Precio);
        Console.WriteLine("Numero de Stock: " + prod.Stock);
        Console.WriteLine("Gracias por tu paciencia. Ten un lindo dia.");
    }
}
#endregion
