namespace Productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tallerDataSet = new Productos.TallerDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.productosTableAdapter = new Productos.TallerDataSetTableAdapters.productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallerDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoGenerateColumns = false;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvProducto.DataSource = this.productosBindingSource;
            this.dgvProducto.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvProducto.Location = new System.Drawing.Point(99, 203);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(633, 138);
            this.dgvProducto.TabIndex = 0;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.tallerDataSet;
            // 
            // tallerDataSet
            // 
            this.tallerDataSet.DataSetName = "TallerDataSet";
            this.tallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.textStock);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.labelDescripcion);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(189, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilla de productos";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(188, 129);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(195, 19);
            this.textStock.TabIndex = 7;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(188, 100);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(195, 19);
            this.textPrecio.TabIndex = 6;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(188, 62);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(195, 19);
            this.textDescripcion.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(188, 28);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(195, 19);
            this.textNombre.TabIndex = 4;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Wendy One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(27, 132);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 17);
            this.labelStock.TabIndex = 3;
            this.labelStock.Text = "Stock";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Wendy One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(27, 99);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 17);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Wendy One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(27, 62);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(98, 17);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Wendy One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(27, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(189, 370);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(87, 21);
            this.botonGuardar.TabIndex = 2;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(413, 370);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(87, 21);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(829, 415);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Wendy One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallerDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonSalir;
        private TallerDataSet tallerDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TallerDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}

