namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            tabProductDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgProduct = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnSave = new Button();
            BtnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            TxtProductObservation = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            tabProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 133);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(152, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 27);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 133);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 492);
            tabControl1.TabIndex = 1;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(BtnClose);
            tabProductList.Controls.Add(BtnDelete);
            tabProductList.Controls.Add(BtnEdit);
            tabProductList.Controls.Add(BtnNew);
            tabProductList.Controls.Add(DgProduct);
            tabProductList.Controls.Add(BtnSearch);
            tabProductList.Controls.Add(TxtSearch);
            tabProductList.Controls.Add(label2);
            tabProductList.Location = new Point(4, 29);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(1043, 459);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            tabProductList.Click += tabProductList_Click;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(TxtProductObservation);
            tabProductDetail.Controls.Add(TxtProductName);
            tabProductDetail.Controls.Add(TxtProductId);
            tabProductDetail.Controls.Add(label5);
            tabProductDetail.Controls.Add(label4);
            tabProductDetail.Controls.Add(label3);
            tabProductDetail.Controls.Add(BtnCancel);
            tabProductDetail.Controls.Add(BtnSave);
            tabProductDetail.Location = new Point(4, 29);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(1043, 459);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(44, 33);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            label2.Click += label2_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(136, 68);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(335, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.search_small;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(59, 68);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(71, 38);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(142, 111);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 51;
            DgProduct.RowTemplate.Height = 29;
            DgProduct.Size = new Size(643, 188);
            DgProduct.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(622, 43);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(67, 51);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(718, 44);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(67, 51);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(791, 129);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(67, 51);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(791, 209);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(67, 51);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(630, 168);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(73, 45);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(732, 168);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(73, 45);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(77, 34);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 2;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(77, 168);
            label4.Name = "label4";
            label4.Size = new Size(177, 31);
            label4.TabIndex = 3;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(77, 323);
            label5.Name = "label5";
            label5.Size = new Size(250, 31);
            label5.TabIndex = 4;
            label5.Text = "Product Observation";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(77, 69);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(184, 27);
            TxtProductId.TabIndex = 5;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(77, 202);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(184, 27);
            TxtProductName.TabIndex = 6;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(77, 365);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.Size = new Size(289, 86);
            TxtProductObservation.TabIndex = 7;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 625);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private Label label2;
        private TabPage tabProductDetail;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductObservation;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}