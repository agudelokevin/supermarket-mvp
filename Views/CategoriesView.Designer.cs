namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            tabCategoriesDetail = new TabPage();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabCategoriesDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(134, 39);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.opciones;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoriesList);
            tabControl1.Controls.Add(tabCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(937, 490);
            tabControl1.TabIndex = 1;
            // 
            // tabCategoriesList
            // 
            tabCategoriesList.Controls.Add(BtnClose);
            tabCategoriesList.Controls.Add(BtnDelete);
            tabCategoriesList.Controls.Add(BtnEdit);
            tabCategoriesList.Controls.Add(BtnNew);
            tabCategoriesList.Controls.Add(label2);
            tabCategoriesList.Controls.Add(TxtSearch);
            tabCategoriesList.Controls.Add(BtnSearch);
            tabCategoriesList.Controls.Add(dataGridView1);
            tabCategoriesList.Location = new Point(4, 24);
            tabCategoriesList.Name = "tabCategoriesList";
            tabCategoriesList.Padding = new Padding(3);
            tabCategoriesList.Size = new Size(929, 462);
            tabCategoriesList.TabIndex = 0;
            tabCategoriesList.Text = "Categories List";
            tabCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(854, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 62);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(569, 393);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(63, 33);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(434, 393);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(63, 33);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = Properties.Resources.nuevo_documento;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(279, 393);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(63, 33);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(108, 85);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 3;
            label2.Text = "Search Categories";
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(102, 126);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(256, 23);
            TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(434, 180);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(53, 29);
            BtnSearch.TabIndex = 1;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(329, 182);
            dataGridView1.TabIndex = 0;
            // 
            // tabCategoriesDetail
            // 
            tabCategoriesDetail.Controls.Add(button2);
            tabCategoriesDetail.Controls.Add(button1);
            tabCategoriesDetail.Location = new Point(4, 24);
            tabCategoriesDetail.Name = "tabCategoriesDetail";
            tabCategoriesDetail.Padding = new Padding(3);
            tabCategoriesDetail.Size = new Size(929, 462);
            tabCategoriesDetail.TabIndex = 1;
            tabCategoriesDetail.Text = "Categories Detail";
            tabCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(311, 356);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(472, 356);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 590);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoriesList.ResumeLayout(false);
            tabCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabCategoriesDetail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabCategoriesList;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView dataGridView1;
        private TabPage tabCategoriesDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button button2;
        private Button button1;
    }
}