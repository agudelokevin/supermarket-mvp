using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{

    public partial class MainView : Form, IMainView
    {

        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnCategories.Click += delegate { ShowCategoriesView?.Invoke(this, EventArgs.Empty); };
            BtnSale.Click += ShowControlVentasForm;
            BtnExit.Click += delegate { this.Close(); };

        }

        private void ShowControlVentasForm(object? sender, EventArgs e)
        {
            ControlVentas controlVentasForm = new ControlVentas();
            controlVentasForm.Show();
            this.Hide();
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowCustumertView;
        public event EventHandler ShowCategoriesView;
        public event EventHandler ShowControlVentas;

        private void BtnPayMode_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
