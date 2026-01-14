using JABASH_SeniorShield.Controller;
using JABASH_SeniorShield.Model;
using JABASH_SeniorShield.View.Meldingen;
using JABASH_SeniorShield.View.Register;
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

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();
            string wachtwoordInput = txtWachtwoord.Text;

            if (string.IsNullOrWhiteSpace(emailInput))
            {
                frmFoutmelding melding = new frmFoutmelding("Invoer ontbreekt", "Vult u alstublieft een e-mailadres in.", "Info");
                melding.ShowDialog();
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailInput, emailPattern))
            {
                frmFoutmelding melding = new frmFoutmelding("Ongeldig e-mailadres", "Denk aan het @-teken en een punt.", "Info");
                melding.ShowDialog();
                return;
            }

            if (string.IsNullOrWhiteSpace(wachtwoordInput))
            {
                frmFoutmelding melding = new frmFoutmelding("Invoer ontbreekt", "Vult u alstublieft uw wachtwoord in.", "Info");
                melding.ShowDialog();
                return;
            }

            UserController userController = new UserController();
            try
            {
                UserModel gebruiker = userController.Login(emailInput, wachtwoordInput);

                if (gebruiker != null)
                {
                    frmFoutmelding melding = new frmFoutmelding("Inloggen gelukt", $"Welkom terug, {gebruiker.Voornaam + " " + gebruiker.Achternaam}!", "Succes");
                    melding.ShowDialog();
                    View.Dashboard.frmHoofdmenu hoofdmenu = new View.Dashboard.frmHoofdmenu();
                    this.Hide();
                    hoofdmenu.Show();
                    // View.frmPhishingDetector phishingDetector = new View.frmPhishingDetector();
                    // this.Hide();
                    // phishingDetector.Show();
                }
                else
                {
                    frmFoutmelding melding = new frmFoutmelding("Inloggen mislukt", "E-mail of wachtwoord is onjuist", "Info");
                    melding.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij verbinden: " + ex.Message);
            }

        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            frmRegistratie registratiescherm = new frmRegistratie();
            registratiescherm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmWachtwoordVergeten wachtwoordVergeten = new frmWachtwoordVergeten();
            wachtwoordVergeten.Show();
        }
    }
}
