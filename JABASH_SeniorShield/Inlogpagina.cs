using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABASH_SeniorShield
{
    public partial class Inlogpagina : Form
    {
        public Inlogpagina()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inlogpagina_Load(object sender, EventArgs e)
        {
            CentreerPanel();
        }

        private void Inlogpagina_Resize(object sender, EventArgs e)
        {
            CentreerPanel();
        }

        private void CentreerPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = ((this.ClientSize.Height - panel1.Height) / 2) + 60;

            logo.Left = (this.ClientSize.Width - logo.Width) / 2;
            logo.Top = panel1.Top - logo.Height - 5;
        }
    }
}
