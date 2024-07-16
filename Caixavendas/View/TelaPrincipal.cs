using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixavendas.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal pago = 0;
            decimal troco = 0;

            total = Convert.ToDecimal(tbxTotal.Text);
            pago = Convert.ToDecimal(tbxPago.Text);
            troco = pago - total;

            tbxTroco.Text = troco.ToString();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            LimpaTudo();

        }
        public void LimpaTudo()
        {
            tbxPago.Text = "";
            tbxTotal.Text = "";
            tbxTroco.Text = string.Empty;
        }

    }
}
