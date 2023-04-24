namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProvidersList = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgProviders = new DataGridView();
            tabProvidersDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProvidersObservation = new TextBox();
            TxtProvidersName = new TextBox();
            TxtProvidersId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(126, 41);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProvidersList);
            tabControl1.Controls.Add(tabProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabProvidersList
            // 
            tabProvidersList.Controls.Add(label6);
            tabProvidersList.Controls.Add(label5);
            tabProvidersList.Controls.Add(label4);
            tabProvidersList.Controls.Add(label3);
            tabProvidersList.Controls.Add(BtnClose);
            tabProvidersList.Controls.Add(BtnDelete);
            tabProvidersList.Controls.Add(BtnEdit);
            tabProvidersList.Controls.Add(BtnNew);
            tabProvidersList.Controls.Add(BtnSearch);
            tabProvidersList.Controls.Add(TxtSearch);
            tabProvidersList.Controls.Add(label2);
            tabProvidersList.Controls.Add(DgProviders);
            tabProvidersList.Location = new Point(4, 24);
            tabProvidersList.Name = "tabProvidersList";
            tabProvidersList.Padding = new Padding(3);
            tabProvidersList.Size = new Size(792, 322);
            tabProvidersList.TabIndex = 0;
            tabProvidersList.Text = "Providers List ";
            tabProvidersList.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(652, 209);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Close";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(554, 209);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Delete";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(652, 80);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 9;
            label4.Text = "Edit";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(554, 80);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "New";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(652, 174);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(47, 32);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(554, 174);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(47, 32);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(652, 98);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(47, 32);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(554, 98);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(47, 32);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(396, 36);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(46, 40);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(62, 54);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(191, 23);
            TxtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(62, 26);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 1;
            label2.Text = "Search Providers";
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(56, 98);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(386, 150);
            DgProviders.TabIndex = 0;
            // 
            // tabProvidersDetail
            // 
            tabProvidersDetail.Controls.Add(BtnCancel);
            tabProvidersDetail.Controls.Add(BtnSave);
            tabProvidersDetail.Controls.Add(TxtProvidersObservation);
            tabProvidersDetail.Controls.Add(TxtProvidersName);
            tabProvidersDetail.Controls.Add(TxtProvidersId);
            tabProvidersDetail.Controls.Add(label9);
            tabProvidersDetail.Controls.Add(label8);
            tabProvidersDetail.Controls.Add(label7);
            tabProvidersDetail.Location = new Point(4, 24);
            tabProvidersDetail.Name = "tabProvidersDetail";
            tabProvidersDetail.Padding = new Padding(3);
            tabProvidersDetail.Size = new Size(792, 322);
            tabProvidersDetail.TabIndex = 1;
            tabProvidersDetail.Text = " Providers Detail";
            tabProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(361, 247);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(55, 36);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(253, 247);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(55, 36);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersObservation
            // 
            TxtProvidersObservation.Location = new Point(361, 123);
            TxtProvidersObservation.Multiline = true;
            TxtProvidersObservation.Name = "TxtProvidersObservation";
            TxtProvidersObservation.PlaceholderText = "&Providers Observation";
            TxtProvidersObservation.Size = new Size(221, 80);
            TxtProvidersObservation.TabIndex = 5;
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(66, 167);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "&Providers Name";
            TxtProvidersName.Size = new Size(157, 23);
            TxtProvidersName.TabIndex = 4;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(66, 56);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.PlaceholderText = "&Providers ID";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(100, 23);
            TxtProvidersId.TabIndex = 3;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(361, 81);
            label9.Name = "label9";
            label9.Size = new Size(221, 25);
            label9.TabIndex = 2;
            label9.Text = "Providers Observation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(66, 123);
            label8.Name = "label8";
            label8.Size = new Size(161, 25);
            label8.TabIndex = 1;
            label8.Text = "&Providers Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(66, 18);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 0;
            label7.Text = "Providers Id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProvidersList.ResumeLayout(false);
            tabProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabProvidersDetail.ResumeLayout(false);
            tabProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProvidersList;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgProviders;
        private TabPage tabProvidersDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersObservation;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersId;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}