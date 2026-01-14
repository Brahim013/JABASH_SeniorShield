using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABASH_SeniorShield.View.Meldingen
{
    public partial class frmFoutmelding : Form
    {
        public frmFoutmelding(string titel, string bericht, string type)
        {
            InitializeComponent();

            lblBericht.Text = bericht;

            if (type == "Succes")
            {
                pnlBericht.BackColor = Color.PaleGreen;
                lblIcoon.Text = "✅";
                btnBegrepen.Text = "Doorgaan";
            }
            else
            {
                pnlBericht.BackColor = Color.FromArgb(210, 225, 240);
                lblIcoon.Text = "ℹ️";
                lblIcoon.ForeColor = Color.FromArgb(44, 62, 80);
                lblBericht.ForeColor = Color.FromArgb(44, 62, 80);
                
            }
        }

        private void frmFoutmelding_Load(object sender, EventArgs e)
        {

        }

        private void btnBegrepen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
