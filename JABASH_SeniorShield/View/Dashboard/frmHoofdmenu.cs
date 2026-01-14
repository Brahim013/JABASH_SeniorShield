using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABASH_SeniorShield.View.Dashboard
{
    public partial class frmHoofdmenu : Form
    {
        public frmHoofdmenu()
        {
            InitializeComponent();
        }

        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            DialogResult resultaat = MessageBox.Show("Weet u zeker dat u wilt afmelden?", "Afmelden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultaat == DialogResult.Yes)
            {
                Inlogpagina inlogpagina = new Inlogpagina();
                inlogpagina.Show();
                this.Close();
            }
        }

        private void btnPhishingHerkenner_Click(object sender, EventArgs e)
        {
            pnlInhoud.Controls.Clear();

            frmPhishingDetector phishingHerkenner = new frmPhishingDetector();

            phishingHerkenner.TopLevel = false;
            phishingHerkenner.FormBorderStyle = FormBorderStyle.None;
            phishingHerkenner.Dock = DockStyle.Fill;

            pnlInhoud.Controls.Add(phishingHerkenner);
            phishingHerkenner.Show();
        }
    }
}
