namespace Supermarket_mvp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            label1 = new Label();
            BtnCompras = new Button();
            BtnSale = new Button();
            BtnCategories = new Button();
            BtnProviders = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnCompras);
            panel1.Controls.Add(BtnSale);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 845);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(0, 511);
            label1.Name = "label1";
            label1.Size = new Size(213, 23);
            label1.TabIndex = 8;
            label1.Text = "Compra y venta(pedidos)";
            // 
            // BtnCompras
            // 
            BtnCompras.BackgroundImage = Properties.Resources.paquetes;
            BtnCompras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCompras.Location = new Point(25, 618);
            BtnCompras.Name = "BtnCompras";
            BtnCompras.Size = new Size(153, 73);
            BtnCompras.TabIndex = 7;
            BtnCompras.UseVisualStyleBackColor = true;
            // 
            // BtnSale
            // 
            BtnSale.BackgroundImage = Properties.Resources.etiqueta_de_venta;
            BtnSale.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSale.Location = new Point(25, 539);
            BtnSale.Name = "BtnSale";
            BtnSale.Size = new Size(153, 73);
            BtnSale.TabIndex = 6;
            BtnSale.UseVisualStyleBackColor = true;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.opciones;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(25, 375);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(153, 73);
            BtnCategories.TabIndex = 5;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = Properties.Resources.providers;
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(25, 296);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(153, 73);
            BtnProviders.TabIndex = 4;
            BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = (Image)resources.GetObject("BtnProduct.BackgroundImage");
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(25, 217);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(153, 73);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar_sesion;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 799);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(238, 46);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = (Image)resources.GetObject("BtnPayMode.BackgroundImage");
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(25, 138);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(153, 73);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            BtnPayMode.Click += BtnPayMode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 845);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "0";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnProviders;
        private Button BtnCategories;
        private Button BtnSale;
        private Label label1;
        private Button BtnCompras;
    }
}