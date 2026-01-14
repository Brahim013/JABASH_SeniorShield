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
    public partial class frmWachtwoordVergeten : Form
    {

        private string gegenereerdeCode;

        public frmWachtwoordVergeten()
        {
            InitializeComponent();
        }

        private void btnCodeVersturen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                frmFoutmelding melding = new frmFoutmelding("Geen invoer", "Vul eerst uw e-mailadres in.", "Info");
                melding.ShowDialog();
                return;
            }

            UserController uc = new UserController();
            string emailMantel = uc.GetMantelzorgerEmail(txtEmail.Text);

            if (emailMantel != null)
            {
                Random rnd = new Random();
                gegenereerdeCode = rnd.Next(100000, 999999).ToString();

                try
                {
                    uc.VerstuurEchteMail(emailMantel, gegenereerdeCode);
                    frmFoutmelding melding = new frmFoutmelding("Email verzonden", $"Er is een e-mail gestuurd naar de mantelzorger ({emailMantel}). " +
                                                                "Vraag hem/haar om de 6-cijferige code.", "Succes");
                    melding.ShowDialog();
                }
                catch (Exception ex)
                {
                    frmFoutmelding melding = new frmFoutmelding("Fout", "Fout bij het versturen van de mail: " + ex.Message, "Info");
                    melding.ShowDialog();
                }
            }
            else
            {
                frmFoutmelding melding = new frmFoutmelding("Onbekend", "Dit e-mailadres is niet bekend in ons systeem", "Info");
                melding.ShowDialog();
            }
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            if (txtHerstelcode.Text != gegenereerdeCode)
            {
                frmFoutmelding melding = new frmFoutmelding("Verkeerde Code", "De ingevoerde code is onjuist", "Info");
                melding.ShowDialog();
                return;
            }

            if (txtWachtwoord.Text != txtWachtwoordBevestiging.Text)
            {
                frmFoutmelding melding = new frmFoutmelding("Wachtwoorden niet hetzelfde", "De nieuwe wachtwoorden komen niet overeen", "Info");
                melding.ShowDialog();
                return;
            }

            UserController uc = new UserController();
            bool succes = uc.UpdateWachtwoord(txtEmail.Text, txtWachtwoordBevestiging.Text);

            if (succes)
            {
                frmFoutmelding melding = new frmFoutmelding("Wachtwoord gewijzigd", "Uw wachtwoord is succesvol gewijzigd! U kunt nu inloggen.", "Succes");
                melding.ShowDialog();
                this.Close();
            }
            else
            {
                frmFoutmelding melding = new frmFoutmelding("Foutmelding", "Er is iets verkeerds gegaan bij het opslaan", "Info");
                melding.ShowDialog();
            }
        }

        private void frmWachtwoordVergeten_Load(object sender, EventArgs e)
        {

        }
    }
}
