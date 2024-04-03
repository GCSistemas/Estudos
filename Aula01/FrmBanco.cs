using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClass;

namespace Aula01
{
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contexto.conta.Deposito(Convert.ToDouble(txtDeposito.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = Contexto.conta.GetSaldo().ToString("N2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmExtratocs frmExtratocs = new FrmExtratocs();
            frmExtratocs.Show();
        }
    }
}
