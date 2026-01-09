using JABASH_SeniorShield.Controller;
using JABASH_SeniorShield.Model;
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

            // 1. Check: Is het veld leeg?
            if (string.IsNullOrWhiteSpace(emailInput))
            {
                MessageBox.Show("Vult u alstublieft uw e-mailadres in.", "Invoer ontbreekt");
                return;
            }

            // 2. Email Validatie (Regex)
            // Dit controleert of er een @ in zit, een punt, en geen rare tekens
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailInput, emailPattern))
            {
                MessageBox.Show("Het ingevulde e-mailadres is niet geldig. Denk aan het @-teken en de punt.", "Ongeldig e-mailadres");
                return;
            }

            // 3. Wachtwoord check (mag ook niet leeg zijn)
            if (string.IsNullOrWhiteSpace(wachtwoordInput))
            {
                MessageBox.Show("Vult u alstublieft uw wachtwoord in.", "Invoer ontbreekt");
                return;
            }

            // 4. Alles is technisch oké -> Controller aanroepen
            UserController userController = new UserController();
            try
            {
                UserModel gebruiker = userController.Login(emailInput, wachtwoordInput);

                if (gebruiker != null)
                {
                    MessageBox.Show($"Welkom terug, {gebruiker.Voornaam + " " + gebruiker.Achternaam}!", "Gelukt");
                }
                else
                {
                    MessageBox.Show("E-mail of wachtwoord is onjuist.", "Inloggen mislukt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij verbinden: " + ex.Message);
            }

        }
    }
}
