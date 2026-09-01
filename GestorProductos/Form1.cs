using GestorProductos.Controllers;
using GestorProductos.Models;
using System.Drawing;

namespace GestorProductos
{
    public partial class Form1 : Form
    {

        // Guarda el Controller que usamos para manejar los productos
        private ProductoController _controller;

        // Indica si estamos agregando o editando
        private bool _modoEdicion = false;

        // Guarda el producto que estamos editando
        private Producto _productoEditando = null;


        // Recibe el Controller desde Program.cs
        public Form1(ProductoController controller)
        {
            InitializeComponent();

            dvgProductos.AutoGenerateColumns = false;

            _controller = controller;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agarra el nombre y saca los espacios en blanco
            string nombre = txtNombre.Text.Trim();

            //se fija q no este vacio
            if (string.IsNullOrEmpty(nombre))
            {
                labelErrorNombre.Visible = true;
                txtNombre.Focus();
                return;
            }

            labelErrorNombre.Visible = false;

            // Valida que el precio sea un número mayor a 0
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                labelErrorPrecio.Visible = true;
                txtPrecio.Focus();
                return;
            }
            labelErrorPrecio.Visible = false;

            // Valida que el stock sea un número y no sea negativo
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                labelErrorStock.Visible = true;
                txtStock.Focus();
                return;
            }

            labelErrorStock.Visible = false;


            // Si estamos editando, modifica el producto
            if (_modoEdicion)
            {
                _productoEditando.Nombre = nombre;
                _productoEditando.Precio = precio;
                _productoEditando.Stock = stock;

                _controller.Modificar(_productoEditando);

                SalirModoEdicion();
            }
            else
            {
                // Si no estamos editando, crea un producto nuevo
                _controller.Agregar(nombre, precio, stock);
            }

            // Actualiza la tabla y limpia los campos
            ActualizarTabla();
            LimpiarCampos();

        }

        // Limpia los campos después de agregar o cancelar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus(); // Deja el cursor listo para escribir otro nombre
        }


        // Actualiza la tabla y el contador
        private void ActualizarTabla()
        {
            var lista = _controller.ObtenerTodos(); // pide al controller todos los productos

            // actualiza el DataGridView
            dvgProductos.DataSource = null;
            dvgProductos.DataSource = lista;



            // muestra la cantidad de productos
            lblContador.Text = $"{lista.Count} PRODUCTOS";


            // Recorremos los productos
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Stock == 0)
                {
                    // Sin stock
                    dvgProductos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dvgProductos.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                }
                else if (lista[i].Stock <= 5)
                {
                    // Poco stock
                    dvgProductos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dvgProductos.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                }
                else
                {
                    // Stock normal
                    dvgProductos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    dvgProductos.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                }
            }


            Bulldog.Visible = true; // muestra la imagen q puse
        }

        // Devuelve el producto que seleccionamos en la tabla
        private Producto ObtenerSeleccionado()
        {
            if (dvgProductos.SelectedRows.Count == 0) // Si no seleccionamos ninguna fila, no devuelve nada
                return null;

            return dvgProductos.SelectedRows[0].DataBoundItem as Producto; // Devuelve el producto de la fila seleccionada
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado(); //agarra el prodcuto q eligio

            if (p == null) // sino selecciona nada, termina
            {
                return;
            }

            //mensaje si queremos eliminarlo
            var confirmar = MessageBox.Show($"ELIMINAR {p.Nombre}?", "CONFIRMAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {

                _controller.Eliminar(p.Id); // le manda el ID al controller para eliminarlo
                ActualizarTabla(); //actualiza la tabla
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();

            if (p == null)
            {
                return;

            }

            _modoEdicion = true; //entramos modo edicion
            _productoEditando = p; //guardamos el producto q estamos editando


            //carga los datos del producto q elegimos al textbox
            txtNombre.Text = p.Nombre;
            txtPrecio.Text = p.Precio.ToString();
            txtStock.Text = p.Stock.ToString();

            ActualizarBotones(); //cambia los botones segun el modo
        }



        private void ActualizarBotones()//cambia los botones depende si estamos editando
        {
            btnAgregar.Text = _modoEdicion ? "GUARDAR " : "Agregar"; // Si estamos editando, cambia el botón a "Guardar cambios si no, queda como "Agregar"
            btnCancelar.Visible = _modoEdicion; // Muestra Cancelar solo cuando estamos editando
            btnEditar.Enabled = !_modoEdicion;  // Desactiva Editar mientras estamos editando
        }
        private void SalirModoEdicion()
        {
            _modoEdicion = false; //dejamos en estar modo edicion
            _productoEditando = null; //ya no tenemos un producto para editar
            ActualizarBotones(); //vuelve a los botones como antes
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SalirModoEdicion();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Agarramos lo que escribió el usuario
            string texto = txtBuscar.Text.Trim();

            // Si no escribió nada, mostramos un aviso
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Escribí un producto para buscar.");
                txtBuscar.Focus();
                return;
            }

            // Buscamos los productos por nombre
            var lista = _controller.ObtenerTodos()
                .Where(p => p.Nombre.ToLower().Contains(texto.ToLower()))
                .ToList();

            // Si no encontramos ningún producto
            if (lista.Count == 0)
            {
                MessageBox.Show("Producto no encontrado.");
                txtBuscar.Focus();
                return;
            }

            // Si encontramos productos, los mostramos
            dvgProductos.DataSource = null;
            dvgProductos.DataSource = lista;
        }
    }
}
