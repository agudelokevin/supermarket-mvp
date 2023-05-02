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
    public partial class ControlVentas : Form
    {
        double precio = 0;
        public ControlVentas()
        {
            InitializeComponent();
            BtnSalir.Click += BtnSalir_Click;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MainView mainForm = new MainView();
            mainForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ControlVentas_Load(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Today.Date.ToString("d");
            LblPrecio.Text = (0).ToString("c");
        }

        private void CboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = CboProducto.Text;
            if (producto.Equals("arroz")) precio = 2200;
            if (producto.Equals("leche")) precio = 5200;
            if (producto.Equals("jabon")) precio = 3200;
            if (producto.Equals("ricostilla")) precio = 5200;
            LblPrecio.Text = precio.ToString("c");

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (CboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
            else if (TxtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
            }
            else if (CboPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de pago");
            }
            else
            {
                //captura datos
                string producto = CboProducto.Text;
                int cantidad = Convert.ToInt32(TxtCantidad.Text);
                string tipo = CboPago.Text;
                //procesar calculo
                double subtotal = cantidad * precio;
                double descuento = 0, recargo = 0;
                if (tipo.Equals("contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                //impresion resultado

                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                LvVenta.Items.Add(fila);

            }
        }

        private void LvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
