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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabProductDetail = new TabPage();
            TxtProductObservation = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(133, 41);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 369);
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
            tabProductList.Location = new Point(4, 24);
            tabProductList.Margin = new Padding(3, 2, 3, 2);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3, 2, 3, 2);
            tabProductList.Size = new Size(912, 341);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            tabProductList.Click += tabProductList_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(692, 157);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(59, 38);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(692, 97);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(59, 38);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(628, 33);
            BtnEdit.Margin = new Padding(3, 2, 3, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(59, 38);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(544, 32);
            BtnNew.Margin = new Padding(3, 2, 3, 2);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(59, 38);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(124, 83);
            DgProduct.Margin = new Padding(3, 2, 3, 2);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 51;
            DgProduct.RowTemplate.Height = 29;
            DgProduct.Size = new Size(563, 141);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.search_small;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(52, 51);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(62, 28);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(119, 51);
            TxtSearch.Margin = new Padding(3, 2, 3, 2);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(294, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(38, 25);
            label2.Name = "label2";
            label2.Size = new Size(174, 27);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            label2.Click += label2_Click;
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
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Margin = new Padding(3, 2, 3, 2);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3, 2, 3, 2);
            tabProductDetail.Size = new Size(912, 341);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(67, 274);
            TxtProductObservation.Margin = new Padding(3, 2, 3, 2);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.Size = new Size(253, 66);
            TxtProductObservation.TabIndex = 7;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(67, 152);
            TxtProductName.Margin = new Padding(3, 2, 3, 2);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(162, 23);
            TxtProductName.TabIndex = 6;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(67, 52);
            TxtProductId.Margin = new Padding(3, 2, 3, 2);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(162, 23);
            TxtProductId.TabIndex = 5;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(67, 242);
            label5.Name = "label5";
            label5.Size = new Size(205, 25);
            label5.TabIndex = 4;
            label5.Text = "Product Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(67, 126);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 3;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(67, 26);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Product Id";
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(640, 126);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(64, 34);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(551, 126);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(64, 34);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 469);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
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