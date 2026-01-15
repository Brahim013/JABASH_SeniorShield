using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace JABASH_SeniorShield.View.Phishingminicursus
{
    public partial class frmPhishingCursus : Form
    {
        // Opslaan van resultaat
        private int _scorePercentage;
        private int _lastCorrectCount;

        // Current page index and side navigation buttons
        // Start on page 1 so the senior reads the introduction first
        private int _currentPage = 1;
        private Button btnNavLeft;
        private Button btnNavRight;

        // Dynamic panel for the "Actuele phishing tekst" (logical page 2)
        private Panel actualTextPanel;
        private TextBox txtActualPhishing;

        public frmPhishingCursus()
        {
            InitializeComponent();
        }

        private void frmPhishingCursus_Load(object sender, EventArgs e)
        {
            // Vul uitlegtekst met volledige tekst uit het NCSC-artikel
            VulUitlegTekst();

            // Make intro text larger and more readable for seniors
            try
            {
                txtExplanation.Font = new Font("Segoe UI", 18F, FontStyle.Regular);
            }
            catch
            {
                // ignore if control missing or font not available
            }

            // Stel juiste antwoorden in via Tag-property van de radiobuttons
            InitializeAntwoorden();

            // Ensure form receives key events
            this.KeyPreview = true;
            this.KeyDown += FrmPhishingCursus_KeyDown;

            // Create persistent side navigation buttons
            CreateSideNavigation();

            // Create dynamic actual phishing text page (logical page 2)
            CreateActualPhishingPage();

            // Style and enlarge result page buttons and labels for better visibility
            try
            {
                lblTitle6.Font = new Font(lblTitle6.Font.FontFamily, 24F, FontStyle.Bold);
                lblScore.Font = new Font(lblScore.Font.FontFamily, 22F, FontStyle.Bold);
                lblResultMessage.Font = new Font(lblResultMessage.Font.FontFamily, 16F, FontStyle.Italic);

                // Make existing retry button more prominent
                btnRetake.Text = "Opnieuw proberen";
                btnRetake.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                btnRetake.Size = new Size(360, 80);
                btnRetake.BackColor = Color.FromArgb(27, 53, 93);
                btnRetake.ForeColor = Color.White;
                btnRetake.FlatStyle = FlatStyle.Flat;
                btnRetake.FlatAppearance.BorderSize = 0;

                // Position retry button on page6 (bottom-left)
                btnRetake.Left = 30;
                btnRetake.Top = 320;
            }
            catch
            {
                // ignore styling errors
            }

            // Add a "Back to introduction" button on the result page so users can review the explanation
            // Create a back-to-intro button that matches the retry button in size and style
            Button btnBackToIntro = new Button();
            btnBackToIntro.Text = "Terug naar uitleg";
            btnBackToIntro.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBackToIntro.Size = btnRetake.Size; // same size
            btnBackToIntro.BackColor = btnRetake.BackColor; // same color
            btnBackToIntro.ForeColor = btnRetake.ForeColor;
            btnBackToIntro.FlatStyle = btnRetake.FlatStyle;
            btnBackToIntro.FlatAppearance.BorderSize = btnRetake.FlatAppearance.BorderSize;
            btnBackToIntro.Click += (s, ev) => { ShowPage(1); };

            // place to the right of retry button, vertically aligned
            btnBackToIntro.Left = btnRetake.Left + btnRetake.Width + 20;
            btnBackToIntro.Top = btnRetake.Top;

            // Ensure added only once
            if (!page6.Controls.Contains(btnBackToIntro))
                page6.Controls.Add(btnBackToIntro);

            // Start on the introduction page so the senior reads before answering
            ShowPage(_currentPage);
        }

        // Handle left/right arrow keys for accessibility (optional)
        private void FrmPhishingCursus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                NextPage();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                PrevPage();
                e.Handled = true;
            }
        }

        private void CreateSideNavigation()
        {
            // Left navigation
            btnNavLeft = new Button
            {
                Width = 56,
                Height = 112,
                Text = "◀",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                BackColor = Color.FromArgb(27, 53, 93),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                TabStop = false
            };
            btnNavLeft.FlatAppearance.BorderSize = 0;
            btnNavLeft.Click += (s, e) => PrevPage();

            // Right navigation
            btnNavRight = new Button
            {
                Width = 56,
                Height = 112,
                Text = "▶",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                BackColor = Color.FromArgb(27, 53, 93),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                TabStop = false
            };
            btnNavRight.FlatAppearance.BorderSize = 0;
            btnNavRight.Click += (s, e) => NextPage();

            // Add to form controls so they float above pages
            this.Controls.Add(btnNavLeft);
            this.Controls.Add(btnNavRight);

            // Position them initially
            CentreerPagina();
        }

        /// <summary>
        /// Create dynamic panel that contains the provided 'actual phishing' long text.
        /// This is logical page 2 between intro and the quiz.
        /// </summary>
        private void CreateActualPhishingPage()
        {
            actualTextPanel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(900, 820),
                Name = "actualTextPanel"
            };

            txtActualPhishing = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Width = 860,
                Height = 640,
                Left = 20,
                Top = 80,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Fill with the long text supplied by the user
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Phishing – Wat is het en hoe herkent u het?");
            sb.AppendLine();
            sb.AppendLine("Wat is phishing?");
            sb.AppendLine();
            sb.AppendLine("Phishing is een truc van internetcriminelen.");
            sb.AppendLine("U ontvangt een e-mail die lijkt alsof hij van een echt bedrijf komt, zoals uw bank, de overheid of een webwinkel.");
            sb.AppendLine();
            sb.AppendLine("In de mail staat vaak dat u iets moet doen:");
            sb.AppendLine();
            sb.AppendLine("Op een knop klikken");
            sb.AppendLine();
            sb.AppendLine("Een betaling uitvoeren");
            sb.AppendLine();
            sb.AppendLine("Uw gegevens invullen");
            sb.AppendLine();
            sb.AppendLine("Maar het bericht is nep.");
            sb.AppendLine("Als u klikt, kunnen criminelen uw gegevens stelen, uw bankrekening leegmaken of schadelijke software op uw computer zetten.");
            sb.AppendLine();
            sb.AppendLine("Daarom is het belangrijk om rustig te kijken voordat u iets doet.");
            sb.AppendLine();
            sb.AppendLine("Controleer altijd de afzender");
            sb.AppendLine();
            sb.AppendLine("Kijk eerst wie de e-mail heeft gestuurd.");
            sb.AppendLine();
            sb.AppendLine("De naam kan er goed uitzien, bijvoorbeeld:");
            sb.AppendLine("\"Rabobank\"");
            sb.AppendLine();
            sb.AppendLine("Maar het e-mailadres erachter is vaak vreemd, bijvoorbeeld:");
            sb.AppendLine("rabobank@rab0-helpdesk.nl");
            sb.AppendLine();
            sb.AppendLine("Let op: hier is de letter \"o\" vervangen door het cijfer \"0\".");
            sb.AppendLine();
            sb.AppendLine("Zo controleert u dit:");
            sb.AppendLine();
            sb.AppendLine("Kijk naar alles achter het @-teken");
            sb.AppendLine();
            sb.AppendLine("Komt dit overeen met de echte website?");
            sb.AppendLine();
            sb.AppendLine("Twijfelt u?\nBel zelf het bedrijf via het telefoonnummer van hun officiële website.\nGebruik nooit een telefoonnummer uit de e-mail.");
            sb.AppendLine();
            sb.AppendLine("Vragen naar persoonsgegevens\nEen echte bank of overheid vraagt nooit via e-mail om:\nWachtwoorden\nPincodes\nBankgegevens\nStaat dit wel in een mail?\nDan is het bijna zeker phishing.");
            sb.AppendLine();
            sb.AppendLine("Taalgebruik en uiterlijk\nModerne nepmails zien er vaak professioneel uit.\nLet op:\nZiet de mail er anders uit dan eerdere mails van dit bedrijf?\nWordt u aangesproken met \"Beste klant\" in plaats van uw naam?\nBij twijfel: niet klikken.");
            sb.AppendLine();
            sb.AppendLine("Spoed en dreiging\nPhishing-mails proberen u onder druk te zetten.\nVoorbeelden:\n\"Uw rekening wordt vandaag geblokkeerd\"\n\"Laatste waarschuwing\"\nEchte bedrijven werken nooit zo via e-mail.\nRustig blijven en eerst controleren.");
            sb.AppendLine();
            sb.AppendLine("Links in e-mails\nLinks in nepmails kunnen u naar valse websites leiden of schadelijke software installeren.\nZo controleert u een link:\nZet de muis boven de link\nBekijk het adres dat verschijnt\nZiet het adres vreemd? Klik niet.");
            sb.AppendLine();
            sb.AppendLine("Verkorte links\nLinks zoals bit.ly of t.co laten niet zien waar u heen gaat.\nDeze zijn extra verdacht in e-mails.");
            sb.AppendLine();
            sb.AppendLine("Bijlagen\nOpen nooit zomaar een bijlage uit een onbekende e-mail.\nZip- of rar-bestanden zijn extra verdacht.\nVerwacht u echt een bestand?\nNeem eerst zelf contact op met de afzender via de officiële website.");
            sb.AppendLine();
            sb.AppendLine("Twijfelt u?\nKlik nergens op.\nVul niets in.\nOpen geen bijlagen.\nZoek zelf het bedrijf op.\nBel het officiële nummer.\nVraag iemand om hulp.");
            sb.AppendLine();
            sb.AppendLine("Samenvatting – De gouden regels\nControleer altijd het e-mailadres\nGeef nooit persoonlijke gegevens via e-mail\nKlik niet op links bij twijfel\nOpen geen onbekende bijlagen\nLaat u niet opjagen door spoedmeldingen\nBel het bedrijf zelf bij twijfel\nOnthoud:\nTwijfel betekent niet klikken.");

            txtActualPhishing.Text = sb.ToString();

            // Add a title label and a Next button similar to other pages
            Label lblActualTitle = new Label
            {
                Font = new Font("Trebuchet MS", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(27, 54, 93),
                Location = new Point(20, 20),
                Size = new Size(860, 48),
                Text = "Actuele phishing tekst",
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button btnNextFromActual = new Button
            {
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(27, 53, 93),
                Location = new Point(730, 740),
                Size = new Size(150, 60),
                Text = "Volgende →",
                FlatStyle = FlatStyle.Flat
            };
            btnNextFromActual.FlatAppearance.BorderSize = 0;
            btnNextFromActual.Click += (s, e) => ShowPage(3); // logical 3 = quiz (physical page2)

            actualTextPanel.Controls.Add(lblActualTitle);
            actualTextPanel.Controls.Add(txtActualPhishing);
            actualTextPanel.Controls.Add(btnNextFromActual);

            // Add actualTextPanel to form controls and initially hide it
            this.Controls.Add(actualTextPanel);
            actualTextPanel.Visible = false;
        }

        /// <summary>
        /// Zorgt ervoor dat de paginapanelen correct gecentreerd blijven bij het wijzigen van de venstergrootte.
        /// Also repositions side navigation buttons.
        /// </summary>
        private void frmPhishingCursus_Resize(object sender, EventArgs e)
        {
            CentreerPagina();
        }

        /// <summary>
        /// Centreert het huidige zichtbare paginapanel op het formulier.
        /// </summary>
        private void CentreerPagina()
        {
            // Bepaal de zichtbare pagina
            Panel huidige = GetCurrentPage();
            if (huidige != null)
            {
                huidige.Left = (this.ClientSize.Width - huidige.Width) / 2;
                huidige.Top = ((this.ClientSize.Height - huidige.Height) / 2);

                // Position nav buttons to the sides of the current page
                if (btnNavLeft != null)
                {
                    btnNavLeft.Left = Math.Max(10, huidige.Left - btnNavLeft.Width - 10);
                    btnNavLeft.Top = huidige.Top + (huidige.Height - btnNavLeft.Height) / 2;
                }
                if (btnNavRight != null)
                {
                    btnNavRight.Left = Math.Min(this.ClientSize.Width - btnNavRight.Width - 10, huidige.Left + huidige.Width + 10);
                    btnNavRight.Top = huidige.Top + (huidige.Height - btnNavRight.Height) / 2;
                }
            }
            else
            {
                // if no page visible, position nav buttons center-left/right
                if (btnNavLeft != null)
                {
                    btnNavLeft.Left = 10;
                    btnNavLeft.Top = (this.ClientSize.Height - btnNavLeft.Height) / 2;
                }
                if (btnNavRight != null)
                {
                    btnNavRight.Left = this.ClientSize.Width - btnNavRight.Width - 10;
                    btnNavRight.Top = (this.ClientSize.Height - btnNavRight.Height) / 2;
                }
            }
        }

        /// <summary>
        /// Haalt de momenteel zichtbare pagina op.
        /// </summary>
        /// <returns>Het zichtbare Panel of null.</returns>
        private Panel GetCurrentPage()
        {
            if (page1.Visible) return page1; // logical 1
            if (actualTextPanel != null && actualTextPanel.Visible) return actualTextPanel; // logical 2
            if (page2.Visible) return page2; // logical 3
            if (page3.Visible) return page3; // logical 4
            if (page4.Visible) return page4; // logical 5
            if (page5.Visible) return page5; // logical 6
            if (page6.Visible) return page6; // logical 7
            return null;
        }

        /// <summary>
        /// Toont de opgegeven pagina en verbergt de overige pagina's.
        /// Logical pages now 1..7 where 2 is the dynamic actualTextPanel.
        /// </summary>
        /// <param name="index">Pagina-nummer (1 t/m 7)</param>
        private void ShowPage(int index)
        {
            if (index < 1) index = 1;
            if (index > 7) index = 7;

            // map logical pages to physical controls
            page1.Visible = index == 1;
            if (actualTextPanel != null) actualTextPanel.Visible = index == 2;
            page2.Visible = index == 3;
            page3.Visible = index == 4;
            page4.Visible = index == 5;
            page5.Visible = index == 6;
            page6.Visible = index == 7;

            _currentPage = index;

            // Update nav buttons enabled state
            if (btnNavLeft != null) btnNavLeft.Enabled = _currentPage > 1;
            if (btnNavRight != null) btnNavRight.Enabled = _currentPage < 7;

            CentreerPagina();
        }

        private void PrevPage()
        {
            ShowPage(_currentPage - 1);
        }

        private void NextPage()
        {
            ShowPage(_currentPage + 1);
        }

        /// <summary>
        /// Maakt de uitlegtekst voor pagina 1 op basis van het NCSC-artikel.
        /// Improved with an introduction and course summary.
        /// </summary>
        private void VulUitlegTekst()
        {
            // Build an attractive intro and content in Dutch
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PHISHING MINICURSUS — KORTE INTRODUCTIE");
            sb.AppendLine();
            sb.AppendLine("Deze minicursus is gebaseerd op adviezen van het Nationaal Cyber Security Centrum (NCSC). " +
                          "We leggen in duidelijke stappen uit hoe u phishingmails herkent en wat u moet doen als u twijfelt.\n");

            sb.AppendLine("Wat kunt u verwachten?");
            sb.AppendLine("• Een korte uitleg met herkenningspunten waar senioren snel mee uit de voeten kunnen.");
            sb.AppendLine("• 10 korte en stimulerende vragen zodat u kunt oefenen.");
            sb.AppendLine("• Bij een score van 70% of hoger: een felicitatie en tips om veilig verder te gaan.");
            sb.AppendLine("• Bij een lagere score: bemoediging en de mogelijkheid om het nogmaals te proberen.\n");

            sb.AppendLine("De vragen zijn bewust kort en duidelijk geformuleerd. Succes!\n");

            sb.AppendLine("INHOUD (SAMENVATTING)\n");
            sb.AppendLine("AFZENDER:\n• Controleer het e-mailadres (alles achter het @-teken).\n");
            sb.AppendLine("LET OP SPOED/DRUK:\n• Berichten die aanzetten tot haast zijn vaak verdacht.\n");
            sb.AppendLine("LINKS:\n• Houd de muis boven een link om het echte adres te bekijken; klik niet zomaar.\n");
            sb.AppendLine("BIJLAGEN:\n• Open geen bijlagen van onbekende afzenders; zip/rar is extra verdacht.\n");

            sb.AppendLine("We wensen u veel succes met de quiz — klik op de rechter pijl om te beginnen of gebruik de toetsen ← en →.");

            txtExplanation.Text = sb.ToString();
        }

        /// <summary>
        /// Stelt de Tag-property van de radiobuttons in voor de juiste antwoorden.
        /// </summary>
        private void InitializeAntwoorden()
        {
            // Vraag 1: Correct antwoord B
            r1A.Tag = null;
            r1B.Tag = "correct";
            r1C.Tag = null;

            // Vraag 2: Correct antwoord A (de naam kan hetzelfde zijn, maar het e-mailadres is anders)
            r2A.Tag = "correct";
            r2B.Tag = null;
            r2C.Tag = null;

            // Vraag 3: Correct antwoord B
            r3A.Tag = null;
            r3B.Tag = "correct";
            r3C.Tag = null;

            // Vraag 4: Correct antwoord B
            r4A.Tag = null;
            r4B.Tag = "correct";
            r4C.Tag = null;

            // Vraag 5: Correct antwoord B
            r5A.Tag = null;
            r5B.Tag = "correct";
            r5C.Tag = null;

            // Vraag 6: Correct antwoord A
            r6A.Tag = "correct";
            r6B.Tag = null;
            r6C.Tag = null;

            // Vraag 7: Correct antwoord A
            r7A.Tag = "correct";
            r7B.Tag = null;
            r7C.Tag = null;

            // Vraag 8: Correct antwoord B
            r8A.Tag = null;
            r8B.Tag = "correct";
            r8C.Tag = null;

            // Vraag 9: Correct antwoord A (zip/rar is verdacht)
            r9A.Tag = "correct";
            r9B.Tag = null;
            r9C.Tag = null;

            // Vraag 10: Correct antwoord B (professioneel uitziende phishingmails)
            r10A.Tag = null;
            r10B.Tag = "correct";
            r10C.Tag = null;

            // Schakel de volgende-knop op pagina5 uit totdat er gecontroleerd is
            btnNext5.Enabled = false;
        }

        /// <summary>
        /// Handler voor "Volgende" knop op pagina 1.
        /// Goes to logical page 2 (actual phishing text).
        /// </summary>
        private void btnNext1_Click(object sender, EventArgs e)
        {
            ShowPage(2);
        }

        /// <summary>
        /// Handler voor "Vorige" knop on the quiz-first page (physical page2, logical 3).
        /// Should go back to the actual text (logical 2).
        /// </summary>
        private void btnBack2_Click(object sender, EventArgs e)
        {
            ShowPage(2);
        }

        /// <summary>
        /// Handler for Next on the quiz-first page (physical page2, logical 3).
        /// Goes to logical 4 (physical page3).
        /// </summary>
        private void btnNext2_Click(object sender, EventArgs e)
        {
            ShowPage(4);
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            ShowPage(3);
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            ShowPage(5);
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            ShowPage(4);
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            ShowPage(6);
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            ShowPage(5);
        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            // Controleer of alle vragen zijn beantwoord
            foreach (var group in GetAlleGroepBoxen())
            {
                bool answered = false;
                foreach (Control ctl in group.Controls)
                {
                    if (ctl is RadioButton rb && rb.Checked)
                    {
                        answered = true;
                        break;
                    }
                }
                if (!answered)
                {
                    // Toon foutmelding
                    lblCheckMessage.Text = "Vul alstublieft alle vragen in voordat u controleert.";
                    lblCheckMessage.ForeColor = Color.DarkRed;
                    return;
                }
            }

            // Alles is ingevuld; bereken score en toon direct feedback on logical page 6 (physical page5)
            BerekenScore();

            // Provide immediate feedback on page5
            lblCheckMessage.Text = $"Score: {_scorePercentage}% ({_lastCorrectCount}/10)";
            if (_scorePercentage >= 70)
            {
                lblCheckMessage.Text += " — ✅ U bent geslaagd!";
                lblCheckMessage.ForeColor = Color.Green;
            }
            else
            {
                lblCheckMessage.Text += " — ❌ Nog niet gehaald. Probeer het opnieuw.";
                lblCheckMessage.ForeColor = Color.DarkRed;
            }

            // Zet next-knop beschikbaar (logical 6 -> next will go to logical 7)
            btnNext5.Enabled = true;
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            // Bereken score and go to result page (logical 7 -> physical page6)
            BerekenScore();
            ToonResultaat();
            ShowPage(7);
        }

        private void btnRetake_Click(object sender, EventArgs e)
        {
            // Reset alle radiobuttons en labels
            foreach (var group in GetAlleGroepBoxen())
            {
                foreach (Control ctl in group.Controls)
                {
                    if (ctl is RadioButton rb)
                    {
                        rb.Checked = false;
                    }
                }
            }

            lblCheckMessage.Text = string.Empty;
            btnNext5.Enabled = false;
            lblScore.Text = string.Empty;
            lblResultMessage.Text = string.Empty;

            // Reset internal counters
            _lastCorrectCount = 0;
            _scorePercentage = 0;

            // Terug naar pagina 1 for a new round
            ShowPage(1);
        }

        /// <summary>
        /// Haalt alle GroupBoxen met vragen op.
        /// </summary>
        /// <returns>IEnumerable van GroupBox</returns>
        private IEnumerable<GroupBox> GetAlleGroepBoxen()
        {
            return new List<GroupBox> { grp1, grp2, grp3, grp4, grp5, grp6, grp7, grp8, grp9, grp10 };
        }

        /// <summary>
        /// Bereken het aantal juiste antwoorden en sla de scorepercentage op.
        /// </summary>
        private void BerekenScore()
        {
            int totaalVragen = 10;
            int juisteAntwoorden = 0;
            foreach (GroupBox group in GetAlleGroepBoxen())
            {
                foreach (Control ctl in group.Controls)
                {
                    if (ctl is RadioButton rb && rb.Checked && rb.Tag != null && rb.Tag.ToString() == "correct")
                    {
                        juisteAntwoorden++;
                    }
                }
            }
            _lastCorrectCount = juisteAntwoorden;
            _scorePercentage = (int)Math.Round((double)juisteAntwoorden / totaalVragen * 100);
        }

        /// <summary>
        /// Toont de resultaten op pagina 6 afhankelijk van de score.
        /// </summary>
        private void ToonResultaat()
        {
            lblScore.Text = $"Score: {_scorePercentage}% ({_lastCorrectCount}/10)";
            if (_scorePercentage >= 70)
            {
                lblResultMessage.Text = "Gefeliciteerd! U bent geslaagd voor de cursus. Blijf waakzaam: controleer altijd het e-mailadres en klik niet zomaar op links. ";
                lblResultMessage.ForeColor = Color.Green;
            }
            else
            {
                lblResultMessage.Text = "U heeft helaas onvoldoende gehaald. Neem nog eens rustig de uitleg door en probeer de quiz opnieuw. U kunt terug naar de quiz met de pijlen of de knop 'Opnieuw'.";
                lblResultMessage.ForeColor = Color.DarkRed;
            }

            // Make result message visually clearer
            lblResultMessage.Font = new Font(lblResultMessage.Font.FontFamily, 16F, FontStyle.Italic);
            lblScore.Font = new Font(lblScore.Font.FontFamily, 20F, FontStyle.Bold);
        }
    }
}