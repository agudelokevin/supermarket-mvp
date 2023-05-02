namespace Supermarket_mvp.Views
{
    partial class ControlVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            LblFecha = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            LblPrecio = new Label();
            label4 = new Label();
            TxtCantidad = new TextBox();
            CboPago = new ComboBox();
            CboProducto = new ComboBox();
            LvVenta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            BtnSalir = new Button();
            BtnCancelar = new Button();
            BtnRegistrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 25);
            label1.TabIndex = 0;
            label1.Text = "Control registro de ventas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(442, 49);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha Actual:";
            label2.Click += label2_Click;
            // 
            // LblFecha
            // 
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFecha.Location = new Point(541, 49);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(67, 20);
            LblFecha.TabIndex = 2;
            LblFecha.Text = "LblFecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(LblPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtCantidad);
            groupBox1.Controls.Add(CboPago);
            groupBox1.Controls.Add(CboProducto);
            groupBox1.Location = new Point(85, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de ventas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(291, 38);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 12;
            label8.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 89);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 11;
            label7.Text = "Seleccione tipo de pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 19);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 10;
            label6.Text = "Seleccione producto";
            // 
            // LblPrecio
            // 
            LblPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecio.Location = new Point(444, 64);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(140, 20);
            LblPrecio.TabIndex = 9;
            LblPrecio.Text = "LblPrecio";
            LblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            LblPrecio.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(444, 34);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio del producto";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(260, 61);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(100, 23);
            TxtCantidad.TabIndex = 2;
            // 
            // CboPago
            // 
            CboPago.FormattingEnabled = true;
            CboPago.Items.AddRange(new object[] { "contado", "tarjeta" });
            CboPago.Location = new Point(8, 112);
            CboPago.Name = "CboPago";
            CboPago.Size = new Size(171, 23);
            CboPago.TabIndex = 1;
            // 
            // CboProducto
            // 
            CboProducto.FormattingEnabled = true;
            CboProducto.Items.AddRange(new object[] { "arroz", "leche", "jabon", "ricostilla" });
            CboProducto.Location = new Point(8, 44);
            CboProducto.Name = "CboProducto";
            CboProducto.Size = new Size(171, 23);
            CboProducto.TabIndex = 0;
            CboProducto.SelectedIndexChanged += CboProducto_SelectedIndexChanged;
            // 
            // LvVenta
            // 
            LvVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LvVenta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            LvVenta.GridLines = true;
            LvVenta.Location = new Point(185, 312);
            LvVenta.Name = "LvVenta";
            LvVenta.Size = new Size(453, 98);
            LvVenta.TabIndex = 4;
            LvVenta.UseCompatibleStateImageBehavior = false;
            LvVenta.View = View.Details;
            LvVenta.SelectedIndexChanged += LvVenta_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cant.";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo de Pago";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Recargo";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio final";
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(649, 323);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 5;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(305, 283);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(453, 283);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 7;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // ControlVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRegistrar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalir);
            Controls.Add(LvVenta);
            Controls.Add(groupBox1);
            Controls.Add(LblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ControlVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControlVentas";
            Load += ControlVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label LblFecha;
        private GroupBox groupBox1;
        private Label LblPrecio;
        private Label label4;
        private TextBox TxtCantidad;
        private ComboBox CboPago;
        private ComboBox CboProducto;
        private ListView LvVenta;
        private Button BtnSalir;
        private Button BtnCancelar;
        private Button BtnRegistrar;
        private Label label8;
        private Label label7;
        private Label label6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}