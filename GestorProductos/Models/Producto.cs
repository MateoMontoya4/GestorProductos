using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProductos.Models
{


    // Esta clase representa a un producto
    public class Producto : IEntidad
    {

        // Datos que tiene cada producto
        public int Id { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }


        // este es el constructor: recibe los datos necesarios para crear un producto.
        public Producto(string nombre, decimal precio, int stock, int id)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Id = id;
        }

      
    }

   
}
