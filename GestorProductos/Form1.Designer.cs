namespace GestorProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            dvgProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            labelErrorNombre = new Label();
            labelErrorPrecio = new Label();
            labelErrorStock = new Label();
            lblContador = new Label();
            pictureProductos = new PictureBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Lime;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(478, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 35);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(208, 30);
            label1.Name = "label1";
            label1.Size = new Size(254, 33);
            label1.TabIndex = 1;
            label1.Text = "NUEVO PRODUCTO";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.ForeColor = Color.Fuchsia;
            txtNombre.Location = new Point(39, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.ForeColor = Color.FromArgb(0, 0, 192);
            txtStock.Location = new Point(202, 95);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Cantidad";
            txtStock.Size = new Size(127, 23);
            txtStock.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.ForeColor = Color.FromArgb(255, 128, 0);
            txtPrecio.Location = new Point(335, 95);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(127, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(193, 179);
            label2.Name = "label2";
            label2.Size = new Size(227, 22);
            label2.TabIndex = 6;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // dvgProductos
            // 
            dvgProductos.BackgroundColor = SystemColors.ActiveCaption;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dvgProductos.GridColor = Color.Black;
            dvgProductos.Location = new Point(96, 213);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProductos.Size = new Size(442, 181);
            dvgProductos.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Nombre";
            Column2.HeaderText = "NOMBRE";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Stock";
            Column3.HeaderText = "STOCK";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Precio";
            Column4.HeaderText = "PRECIO";
            Column4.Name = "Column4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Image = Properties.Resources._1170577;
            label3.Location = new Point(69, 179);
            label3.Name = "label3";
            label3.Size = new Size(0, 33);
            label3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1170577;
            pictureBox1.Location = new Point(520, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelErrorNombre
            // 
            labelErrorNombre.AutoSize = true;
            labelErrorNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorNombre.ForeColor = Color.Red;
            labelErrorNombre.Location = new Point(25, 123);
            labelErrorNombre.Name = "labelErrorNombre";
            labelErrorNombre.Size = new Size(171, 15);
            labelErrorNombre.TabIndex = 10;
            labelErrorNombre.Text = "EL NOMBRE EL OBLIGATORIO\r\n";
            labelErrorNombre.Visible = false;
            // 
            // labelErrorPrecio
            // 
            labelErrorPrecio.AutoSize = true;
            labelErrorPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorPrecio.ForeColor = Color.Red;
            labelErrorPrecio.Location = new Point(335, 121);
            labelErrorPrecio.Name = "labelErrorPrecio";
            labelErrorPrecio.Size = new Size(119, 17);
            labelErrorPrecio.TabIndex = 11;
            labelErrorPrecio.Text = "PRECIO INVALIDO";
            labelErrorPrecio.Visible = false;
            // 
            // labelErrorStock
            // 
            labelErrorStock.AutoSize = true;
            labelErrorStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorStock.ForeColor = Color.Red;
            labelErrorStock.Location = new Point(208, 121);
            labelErrorStock.Name = "labelErrorStock";
            labelErrorStock.Size = new Size(115, 17);
            labelErrorStock.TabIndex = 12;
            labelErrorStock.Text = "STOCK INVALIDO";
            labelErrorStock.Visible = false;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContador.ForeColor = Color.Blue;
            lblContador.Location = new Point(250, 415);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(141, 25);
            lblContador.TabIndex = 13;
            lblContador.Text = "0 PRODUCTOS";
            // 
            // pictureProductos
            // 
            pictureProductos.Image = Properties.Resources._1312307;
            pictureProductos.Location = new Point(388, 400);
            pictureProductos.Name = "pictureProductos";
            pictureProductos.Size = new Size(88, 50);
            pictureProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProductos.TabIndex = 14;
            pictureProductos.TabStop = false;
            pictureProductos.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(574, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Blue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.Menu;
            btnEditar.Location = new Point(574, 265);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 37);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Menu;
            btnCancelar.Location = new Point(574, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 42);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(691, 464);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(pictureProductos);
            Controls.Add(lblContador);
            Controls.Add(labelErrorStock);
            Controls.Add(labelErrorPrecio);
            Controls.Add(labelErrorNombre);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dvgProductos);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "Gestion De Productos";
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label label2;
        private DataGridView dvgProductos;
        private Label label3;
        private PictureBox pictureBox1;
        private Label labelErrorNombre;
        private Label labelErrorPrecio;
        private Label labelErrorStock;
        private Label lblContador;
        private PictureBox pictureProductos;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
