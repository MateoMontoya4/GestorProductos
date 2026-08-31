using GestorProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace GestorProductos.Controllers
{
    public class ProductoController
    {
        // Lista donde vamos a guardar los productos
        private List<Producto> productos = new List<Producto>();


        // Agrega un producto a la lista
        // Recibe el nombre, precio y stock desde el Form.
        public void Agregar(string nombre, decimal precio, int stock)
        {
            // Crea un nuevo objeto Producto. // El ID se genera automáticamente según la cantidad de productos + 1.
            Producto temp = new Producto(nombre, precio, stock, productos.Count() + 1);
            productos.Add(temp);
        }

        public void Eliminar(int id)
        {
            productos.RemoveAll(p => p.Id == id);
        }

        // Modifica los datos de un producto existente.
        public void Modificar(Producto modificado)
        {

            // Busca en la lista el producto que tenga el mismo ID que el producto que queremos modificar.
            var p = productos.Find(x => x.Id == modificado.Id);

            // Si no encuentra el producto, sale del método.
            if (p == null)
                return;


            // Actualiza los datos del producto encontrado.
            p.Nombre = modificado.Nombre;
            p.Precio = modificado.Precio;
            p.Stock = modificado.Stock;
        }

       

        // Devuelve todos los productos, el form lo usa para mostrar los productos
        public List<Producto> ObtenerTodos()
        {
            return productos;
        }

    }
}
