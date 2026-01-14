using JABASH_SeniorShield.Controller;
using JABASH_SeniorShield.View.Meldingen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JABASH_SeniorShield.View.Register
{
    public partial class frmRegistratie : Form
    {
        public frmRegistratie()
        {
            InitializeComponent();
        }

        private void frmRegistratie_Load(object sender, EventArgs e)
        {
            CentreerPanel();
        }

        private void frmRegistratie_Resize(object sender, EventArgs e)
        {
            CentreerPanel();
        }

        private void CentreerPanel()
        {

        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVoornaam.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtWachtwoord.Text) ||
                string.IsNullOrWhiteSpace(txtEmailMantelzorger.Text))
            {
                frmFoutmelding melding = new frmFoutmelding("Incomplete invoer", "Vul alstublieft alle velden in. De mantelzorger is later nodig om uw wachtwoord te kunnen herstellen.", "Info");
                melding.ShowDialog();
                return;
            }

            UserController uc = new UserController();

            try
            {
                bool succes = uc.Registratie(
                    txtVoornaam.Text,
                    txtAchternaam.Text,
                    txtEmail.Text,
                    txtWachtwoord.Text,
                    txtEmailMantelzorger.Text
                );

                if (succes)
                {
                    frmFoutmelding melding = new frmFoutmelding("Account aangemaakt", "Account is succesvol aangemaakt! U kunt nu inloggen.", "Succes");
                    melding.ShowDialog();
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                frmFoutmelding melding = new frmFoutmelding("Database fout", "Er is iets misgegaan: " + ex.Message, "Info");
                melding.ShowDialog();
            }
        }
    }
}
