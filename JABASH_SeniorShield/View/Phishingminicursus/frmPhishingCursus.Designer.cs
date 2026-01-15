using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JABASH_SeniorShield.View.Phishingminicursus
{
    /// <summary>
    /// Automatisch gegenereerde Designer-code voor de phishingcursus. Deze definieert
    /// de lay-out en visuele elementen van de cursus met meerdere pagina's.
    /// Pas deze code niet handmatig aan buiten deze patch; gebruik de code-behind
    /// voor logica en dynamische aanpassingen.
    /// </summary>
    partial class frmPhishingCursus
    {
        /// <summary>
        /// Vereiste designer variabele.
        /// </summary>
        private IContainer components = null;

        // Pagina panels
        private Panel page1;
        private Panel page2;
        private Panel page3;
        private Panel page4;
        private Panel page5;
        private Panel page6;

        // Pagina 1 controls
        private Label lblTitle1;
        private TextBox txtExplanation;
        private Button btnNext1;

        // Pagina 2 controls
        private Label lblTitle2;
        private Label lblInstr2;
        private GroupBox grp1;
        private RadioButton r1A;
        private RadioButton r1B;
        private RadioButton r1C;
        private GroupBox grp2;
        private RadioButton r2A;
        private RadioButton r2B;
        private RadioButton r2C;
        private Button btnNext2;
        private Button btnBack2;

        // Pagina 3 controls
        private Label lblTitle3;
        private GroupBox grp3;
        private RadioButton r3A;
        private RadioButton r3B;
        private RadioButton r3C;
        private GroupBox grp4;
        private RadioButton r4A;
        private RadioButton r4B;
        private RadioButton r4C;
        private GroupBox grp5;
        private RadioButton r5A;
        private RadioButton r5B;
        private RadioButton r5C;
        private Button btnNext3;
        private Button btnBack3;

        // Pagina 4 controls
        private Label lblTitle4;
        private GroupBox grp6;
        private RadioButton r6A;
        private RadioButton r6B;
        private RadioButton r6C;
        private GroupBox grp7;
        private RadioButton r7A;
        private RadioButton r7B;
        private RadioButton r7C;
        private GroupBox grp8;
        private RadioButton r8A;
        private RadioButton r8B;
        private RadioButton r8C;
        private Button btnNext4;
        private Button btnBack4;

        // Pagina 5 controls
        private Label lblTitle5;
        private GroupBox grp9;
        private RadioButton r9A;
        private RadioButton r9B;
        private RadioButton r9C;
        private GroupBox grp10;
        private RadioButton r10A;
        private RadioButton r10B;
        private RadioButton r10C;
        private Button btnCheckAnswers;
        private Label lblCheckMessage;
        private Button btnNext5;
        private Button btnBack5;

        // Pagina 6 controls
        private Label lblTitle6;
        private Label lblScore;
        private Label lblResultMessage;
        private Button btnRetake;

        /// <summary>
        /// Opruimen van resources die in gebruik zijn.
        /// </summary>
        /// <param name="disposing">true als beheerde resources verwijderd moeten worden; anders false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code gegenereerd door Windows Form Designer

        /// <summary>
        /// Vereiste methode voor Designerondersteuning – wijzig de inhoud van deze methode niet
        /// met de code-editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Form instellingen
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 980);
            this.Name = "frmPhishingCursus";
            this.Text = "Phishing Cursus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhishingCursus_Load);
            this.Resize += new System.EventHandler(this.frmPhishingCursus_Resize);

            // Pagina 1
            this.page1 = new System.Windows.Forms.Panel();
            this.page1.BackColor = System.Drawing.Color.White;
            this.page1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page1.Location = new System.Drawing.Point(50, 50);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(900, 820);
            this.page1.TabIndex = 0;

            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle1.Location = new System.Drawing.Point(20, 20);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(860, 50);
            this.lblTitle1.Text = "Phishing minicursus";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.txtExplanation.Location = new System.Drawing.Point(20, 80);
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Multiline = true;
            this.txtExplanation.ReadOnly = true;
            this.txtExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplanation.Size = new System.Drawing.Size(860, 640);
            // Gebruik een grotere lettergrootte voor betere leesbaarheid
            this.txtExplanation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.txtExplanation.BackColor = System.Drawing.Color.White;
            this.txtExplanation.BorderStyle = BorderStyle.None;

            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnNext1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnNext1.Location = new System.Drawing.Point(730, 740);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(150, 60);
            this.btnNext1.Text = "Volgende →";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);

            // Voeg controls toe aan pagina1
            this.page1.Controls.Add(this.lblTitle1);
            this.page1.Controls.Add(this.txtExplanation);
            this.page1.Controls.Add(this.btnNext1);

            // Pagina 2
            this.page2 = new System.Windows.Forms.Panel();
            this.page2.BackColor = System.Drawing.Color.White;
            this.page2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page2.Location = new System.Drawing.Point(50, 50);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(900, 820);
            this.page2.TabIndex = 1;

            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle2.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle2.Location = new System.Drawing.Point(20, 20);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(860, 48);
            this.lblTitle2.Text = "Quiz – Deel 1";

            this.lblInstr2 = new System.Windows.Forms.Label();
            this.lblInstr2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.lblInstr2.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblInstr2.Location = new System.Drawing.Point(20, 70);
            this.lblInstr2.Name = "lblInstr2";
            this.lblInstr2.Size = new System.Drawing.Size(860, 80);
            this.lblInstr2.Text = "Beantwoord de onderstaande vragen. Kies voor elke vraag A, B of C.";
            this.lblInstr2.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            // Vraag 1
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grp1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp1.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp1.Location = new System.Drawing.Point(20, 160);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(860, 140);
            this.grp1.TabStop = false;
            this.grp1.Text = "1. Wat controleert u als eerste bij een verdachte e-mail?";

            this.r1A = new System.Windows.Forms.RadioButton();
            this.r1A.AutoSize = true;
            this.r1A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r1A.Location = new System.Drawing.Point(20, 40);
            this.r1A.Name = "r1A";
            this.r1A.Size = new System.Drawing.Size(461, 32);
            this.r1A.Text = "A. Alleen de naam van de afzender";
            this.r1A.UseVisualStyleBackColor = true;

            this.r1B = new System.Windows.Forms.RadioButton();
            this.r1B.AutoSize = true;
            this.r1B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r1B.Location = new System.Drawing.Point(20, 70);
            this.r1B.Name = "r1B";
            this.r1B.Size = new System.Drawing.Size(473, 32);
            this.r1B.Text = "B. Het e-mailadres en het deel achter het @-teken";
            this.r1B.UseVisualStyleBackColor = true;

            this.r1C = new System.Windows.Forms.RadioButton();
            this.r1C.AutoSize = true;
            this.r1C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r1C.Location = new System.Drawing.Point(20, 100);
            this.r1C.Name = "r1C";
            this.r1C.Size = new System.Drawing.Size(367, 32);
            this.r1C.Text = "C. Of er een plaatje in staat";
            this.r1C.UseVisualStyleBackColor = true;

            this.grp1.Controls.Add(this.r1A);
            this.grp1.Controls.Add(this.r1B);
            this.grp1.Controls.Add(this.r1C);

            // Vraag 2
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp2.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp2.Location = new System.Drawing.Point(20, 310);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(860, 140);
            this.grp2.TabStop = false;
            this.grp2.Text = "2. Waarom kan een e-mail nep zijn terwijl de naam klopt?";

            this.r2A = new System.Windows.Forms.RadioButton();
            this.r2A.AutoSize = true;
            this.r2A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r2A.Location = new System.Drawing.Point(20, 40);
            this.r2A.Name = "r2A";
            this.r2A.Size = new System.Drawing.Size(693, 32);
            this.r2A.Text = "A. De naam kan hetzelfde zijn, maar het e-mailadres is anders";
            this.r2A.UseVisualStyleBackColor = true;

            this.r2B = new System.Windows.Forms.RadioButton();
            this.r2B.AutoSize = true;
            this.r2B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r2B.Location = new System.Drawing.Point(20, 70);
            this.r2B.Name = "r2B";
            this.r2B.Size = new System.Drawing.Size(429, 32);
            this.r2B.Text = "B. Echte bedrijven sturen nooit e-mail";
            this.r2B.UseVisualStyleBackColor = true;

            this.r2C = new System.Windows.Forms.RadioButton();
            this.r2C.AutoSize = true;
            this.r2C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r2C.Location = new System.Drawing.Point(20, 100);
            this.r2C.Name = "r2C";
            this.r2C.Size = new System.Drawing.Size(511, 32);
            this.r2C.Text = "C. Omdat logo’s altijd ontbreken";
            this.r2C.UseVisualStyleBackColor = true;

            this.grp2.Controls.Add(this.r2A);
            this.grp2.Controls.Add(this.r2B);
            this.grp2.Controls.Add(this.r2C);

            // Navigatieknoppen voor pagina2
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnBack2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnBack2.Location = new System.Drawing.Point(20, 740);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(150, 60);
            this.btnBack2.Text = "← Vorige";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);

            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnNext2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnNext2.Location = new System.Drawing.Point(730, 740);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(150, 60);
            this.btnNext2.Text = "Volgende →";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);

            // Voeg controls toe aan pagina2
            this.page2.Controls.Add(this.lblTitle2);
            this.page2.Controls.Add(this.lblInstr2);
            this.page2.Controls.Add(this.grp1);
            this.page2.Controls.Add(this.grp2);
            this.page2.Controls.Add(this.btnBack2);
            this.page2.Controls.Add(this.btnNext2);

            // Pagina 3
            this.page3 = new System.Windows.Forms.Panel();
            this.page3.BackColor = System.Drawing.Color.White;
            this.page3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page3.Location = new System.Drawing.Point(50, 50);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(900, 820);
            this.page3.TabIndex = 2;

            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle3.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle3.Location = new System.Drawing.Point(20, 20);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(860, 48);
            this.lblTitle3.Text = "Quiz – Deel 2";

            // Vraag 3
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.grp3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp3.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp3.Location = new System.Drawing.Point(20, 80);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(860, 140);
            this.grp3.TabStop = false;
            this.grp3.Text = "3. Wat is verdacht aan een domeinnaam waarin I en 1 door elkaar lijken?";

            this.r3A = new System.Windows.Forms.RadioButton();
            this.r3A.AutoSize = true;
            this.r3A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r3A.Location = new System.Drawing.Point(20, 40);
            this.r3A.Name = "r3A";
            this.r3A.Size = new System.Drawing.Size(426, 32);
            this.r3A.Text = "A. Dat maakt het juist veilig";
            this.r3A.UseVisualStyleBackColor = true;

            this.r3B = new System.Windows.Forms.RadioButton();
            this.r3B.AutoSize = true;
            this.r3B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r3B.Location = new System.Drawing.Point(20, 70);
            this.r3B.Name = "r3B";
            this.r3B.Size = new System.Drawing.Size(623, 32);
            this.r3B.Text = "B. Het kan een truc zijn om een nep domeinnaam te verbergen";
            this.r3B.UseVisualStyleBackColor = true;

            this.r3C = new System.Windows.Forms.RadioButton();
            this.r3C.AutoSize = true;
            this.r3C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r3C.Location = new System.Drawing.Point(20, 100);
            this.r3C.Name = "r3C";
            this.r3C.Size = new System.Drawing.Size(514, 32);
            this.r3C.Text = "C. Het betekent dat het bericht spamvrij is";
            this.r3C.UseVisualStyleBackColor = true;

            this.grp3.Controls.Add(this.r3A);
            this.grp3.Controls.Add(this.r3B);
            this.grp3.Controls.Add(this.r3C);

            // Vraag 4
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.grp4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp4.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp4.Location = new System.Drawing.Point(20, 230);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(860, 140);
            this.grp4.TabStop = false;
            this.grp4.Text = "4. Een mail vraagt: 'Werk uw gegevens bij via deze link'. Wat doet u?";

            this.r4A = new System.Windows.Forms.RadioButton();
            this.r4A.AutoSize = true;
            this.r4A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r4A.Location = new System.Drawing.Point(20, 40);
            this.r4A.Name = "r4A";
            this.r4A.Size = new System.Drawing.Size(436, 32);
            this.r4A.Text = "A. Direct klikken en invullen";
            this.r4A.UseVisualStyleBackColor = true;

            this.r4B = new System.Windows.Forms.RadioButton();
            this.r4B.AutoSize = true;
            this.r4B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r4B.Location = new System.Drawing.Point(20, 70);
            this.r4B.Name = "r4B";
            this.r4B.Size = new System.Drawing.Size(744, 32);
            this.r4B.Text = "B. Eerst zelf het bedrijf bellen via de echte website";
            this.r4B.UseVisualStyleBackColor = true;

            this.r4C = new System.Windows.Forms.RadioButton();
            this.r4C.AutoSize = true;
            this.r4C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r4C.Location = new System.Drawing.Point(20, 100);
            this.r4C.Name = "r4C";
            this.r4C.Size = new System.Drawing.Size(465, 32);
            this.r4C.Text = "C. De mail beantwoorden met uw gegevens";
            this.r4C.UseVisualStyleBackColor = true;

            this.grp4.Controls.Add(this.r4A);
            this.grp4.Controls.Add(this.r4B);
            this.grp4.Controls.Add(this.r4C);

            // Vraag 5
            this.grp5 = new System.Windows.Forms.GroupBox();
            this.grp5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp5.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp5.Location = new System.Drawing.Point(20, 380);
            this.grp5.Name = "grp5";
            this.grp5.Size = new System.Drawing.Size(860, 140);
            this.grp5.TabStop = false;
            this.grp5.Text = "5. Welke tekst is verdacht?";

            this.r5A = new System.Windows.Forms.RadioButton();
            this.r5A.AutoSize = true;
            this.r5A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r5A.Location = new System.Drawing.Point(20, 40);
            this.r5A.Name = "r5A";
            this.r5A.Size = new System.Drawing.Size(328, 32);
            this.r5A.Text = "A. Neem gerust de tijd";
            this.r5A.UseVisualStyleBackColor = true;

            this.r5B = new System.Windows.Forms.RadioButton();
            this.r5B.AutoSize = true;
            this.r5B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r5B.Location = new System.Drawing.Point(20, 70);
            this.r5B.Name = "r5B";
            this.r5B.Size = new System.Drawing.Size(573, 32);
            this.r5B.Text = "B. Laatste waarschuwing: vandaag betalen!";
            this.r5B.UseVisualStyleBackColor = true;

            this.r5C = new System.Windows.Forms.RadioButton();
            this.r5C.AutoSize = true;
            this.r5C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r5C.Location = new System.Drawing.Point(20, 100);
            this.r5C.Name = "r5C";
            this.r5C.Size = new System.Drawing.Size(352, 32);
            this.r5C.Text = "C. Fijne dag gewenst";
            this.r5C.UseVisualStyleBackColor = true;

            this.grp5.Controls.Add(this.r5A);
            this.grp5.Controls.Add(this.r5B);
            this.grp5.Controls.Add(this.r5C);

            // Navigatieknoppen pagina3
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnBack3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack3.ForeColor = System.Drawing.Color.White;
            this.btnBack3.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnBack3.Location = new System.Drawing.Point(20, 740);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(150, 60);
            this.btnBack3.Text = "← Vorige";
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);

            this.btnNext3 = new System.Windows.Forms.Button();
            this.btnNext3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnNext3.ForeColor = System.Drawing.Color.White;
            this.btnNext3.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnNext3.Location = new System.Drawing.Point(730, 740);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(150, 60);
            this.btnNext3.Text = "Volgende →";
            this.btnNext3.UseVisualStyleBackColor = false;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);

            // Voeg controls toe aan pagina3
            this.page3.Controls.Add(this.lblTitle3);
            this.page3.Controls.Add(this.grp3);
            this.page3.Controls.Add(this.grp4);
            this.page3.Controls.Add(this.grp5);
            this.page3.Controls.Add(this.btnBack3);
            this.page3.Controls.Add(this.btnNext3);

            // Pagina 4
            this.page4 = new System.Windows.Forms.Panel();
            this.page4.BackColor = System.Drawing.Color.White;
            this.page4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page4.Location = new System.Drawing.Point(50, 50);
            this.page4.Name = "page4";
            this.page4.Size = new System.Drawing.Size(900, 820);
            this.page4.TabIndex = 3;

            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle4.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle4.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle4.Location = new System.Drawing.Point(20, 20);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(860, 48);
            this.lblTitle4.Text = "Quiz – Deel 3";

            // Vraag 6
            this.grp6 = new System.Windows.Forms.GroupBox();
            this.grp6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp6.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp6.Location = new System.Drawing.Point(20, 80);
            this.grp6.Name = "grp6";
            this.grp6.Size = new System.Drawing.Size(860, 140);
            this.grp6.TabStop = false;
            this.grp6.Text = "6. Hoe controleert u een link zonder te klikken?";

            this.r6A = new System.Windows.Forms.RadioButton();
            this.r6A.AutoSize = true;
            this.r6A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r6A.Location = new System.Drawing.Point(20, 40);
            this.r6A.Name = "r6A";
            this.r6A.Size = new System.Drawing.Size(699, 32);
            this.r6A.Text = "A. De muis boven de link houden en het adres bekijken";
            this.r6A.UseVisualStyleBackColor = true;

            this.r6B = new System.Windows.Forms.RadioButton();
            this.r6B.AutoSize = true;
            this.r6B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r6B.Location = new System.Drawing.Point(20, 70);
            this.r6B.Name = "r6B";
            this.r6B.Size = new System.Drawing.Size(383, 32);
            this.r6B.Text = "B. Altijd dubbelklikken";
            this.r6B.UseVisualStyleBackColor = true;

            this.r6C = new System.Windows.Forms.RadioButton();
            this.r6C.AutoSize = true;
            this.r6C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r6C.Location = new System.Drawing.Point(20, 100);
            this.r6C.Name = "r6C";
            this.r6C.Size = new System.Drawing.Size(409, 32);
            this.r6C.Text = "C. Alleen naar de kleur kijken";
            this.r6C.UseVisualStyleBackColor = true;

            this.grp6.Controls.Add(this.r6A);
            this.grp6.Controls.Add(this.r6B);
            this.grp6.Controls.Add(this.r6C);

            // Vraag 7
            this.grp7 = new System.Windows.Forms.GroupBox();
            this.grp7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp7.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp7.Location = new System.Drawing.Point(20, 230);
            this.grp7.Name = "grp7";
            this.grp7.Size = new System.Drawing.Size(860, 140);
            this.grp7.TabStop = false;
            this.grp7.Text = "7. Waarom zijn verkorte links (bit.ly) extra verdacht?";

            this.r7A = new System.Windows.Forms.RadioButton();
            this.r7A.AutoSize = true;
            this.r7A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r7A.Location = new System.Drawing.Point(20, 40);
            this.r7A.Name = "r7A";
            this.r7A.Size = new System.Drawing.Size(540, 32);
            this.r7A.Text = "A. U ziet niet waar de link echt naartoe gaat";
            this.r7A.UseVisualStyleBackColor = true;

            this.r7B = new System.Windows.Forms.RadioButton();
            this.r7B.AutoSize = true;
            this.r7B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r7B.Location = new System.Drawing.Point(20, 70);
            this.r7B.Name = "r7B";
            this.r7B.Size = new System.Drawing.Size(452, 32);
            this.r7B.Text = "B. Ze werken niet op Windows";
            this.r7B.UseVisualStyleBackColor = true;

            this.r7C = new System.Windows.Forms.RadioButton();
            this.r7C.AutoSize = true;
            this.r7C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r7C.Location = new System.Drawing.Point(20, 100);
            this.r7C.Name = "r7C";
            this.r7C.Size = new System.Drawing.Size(479, 32);
            this.r7C.Text = "C. Ze zijn altijd van de overheid";
            this.r7C.UseVisualStyleBackColor = true;

            this.grp7.Controls.Add(this.r7A);
            this.grp7.Controls.Add(this.r7B);
            this.grp7.Controls.Add(this.r7C);

            // Vraag 8
            this.grp8 = new System.Windows.Forms.GroupBox();
            this.grp8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp8.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp8.Location = new System.Drawing.Point(20, 380);
            this.grp8.Name = "grp8";
            this.grp8.Size = new System.Drawing.Size(860, 140);
            this.grp8.TabStop = false;
            this.grp8.Text = "8. Wat doet u met een onverwachte bijlage van een onbekende afzender?";

            this.r8A = new System.Windows.Forms.RadioButton();
            this.r8A.AutoSize = true;
            this.r8A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r8A.Location = new System.Drawing.Point(20, 40);
            this.r8A.Name = "r8A";
            this.r8A.Size = new System.Drawing.Size(375, 32);
            this.r8A.Text = "A. Openen om te kijken";
            this.r8A.UseVisualStyleBackColor = true;

            this.r8B = new System.Windows.Forms.RadioButton();
            this.r8B.AutoSize = true;
            this.r8B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r8B.Location = new System.Drawing.Point(20, 70);
            this.r8B.Name = "r8B";
            this.r8B.Size = new System.Drawing.Size(538, 32);
            this.r8B.Text = "B. Niet openen en eerst controleren";
            this.r8B.UseVisualStyleBackColor = true;

            this.r8C = new System.Windows.Forms.RadioButton();
            this.r8C.AutoSize = true;
            this.r8C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r8C.Location = new System.Drawing.Point(20, 100);
            this.r8C.Name = "r8C";
            this.r8C.Size = new System.Drawing.Size(568, 32);
            this.r8C.Text = "C. Doorsturen naar iemand anders";
            this.r8C.UseVisualStyleBackColor = true;

            this.grp8.Controls.Add(this.r8A);
            this.grp8.Controls.Add(this.r8B);
            this.grp8.Controls.Add(this.r8C);

            // Navigatieknoppen pagina4
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnBack4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack4.ForeColor = System.Drawing.Color.White;
            this.btnBack4.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnBack4.Location = new System.Drawing.Point(20, 740);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(150, 60);
            this.btnBack4.Text = "← Vorige";
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);

            this.btnNext4 = new System.Windows.Forms.Button();
            this.btnNext4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnNext4.ForeColor = System.Drawing.Color.White;
            this.btnNext4.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnNext4.Location = new System.Drawing.Point(730, 740);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(150, 60);
            this.btnNext4.Text = "Volgende →";
            this.btnNext4.UseVisualStyleBackColor = false;
            this.btnNext4.Click += new System.EventHandler(this.btnNext4_Click);

            // Voeg controls toe aan pagina4
            this.page4.Controls.Add(this.lblTitle4);
            this.page4.Controls.Add(this.grp6);
            this.page4.Controls.Add(this.grp7);
            this.page4.Controls.Add(this.grp8);
            this.page4.Controls.Add(this.btnBack4);
            this.page4.Controls.Add(this.btnNext4);

            // Pagina 5
            this.page5 = new System.Windows.Forms.Panel();
            this.page5.BackColor = System.Drawing.Color.White;
            this.page5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page5.Location = new System.Drawing.Point(50, 50);
            this.page5.Name = "page5";
            this.page5.Size = new System.Drawing.Size(900, 820);
            this.page5.TabIndex = 4;

            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle5.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle5.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle5.Location = new System.Drawing.Point(20, 20);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(860, 48);
            this.lblTitle5.Text = "Quiz – Deel 4";

            // Vraag 9
            this.grp9 = new System.Windows.Forms.GroupBox();
            this.grp9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp9.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp9.Location = new System.Drawing.Point(20, 80);
            this.grp9.Name = "grp9";
            this.grp9.Size = new System.Drawing.Size(860, 140);
            this.grp9.TabStop = false;
            this.grp9.Text = "9. Welke bijlage is extra verdacht?";

            this.r9A = new System.Windows.Forms.RadioButton();
            this.r9A.AutoSize = true;
            this.r9A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r9A.Location = new System.Drawing.Point(20, 40);
            this.r9A.Name = "r9A";
            this.r9A.Size = new System.Drawing.Size(184, 32);
            this.r9A.Text = "A. Zip/Rar";
            this.r9A.UseVisualStyleBackColor = true;

            this.r9B = new System.Windows.Forms.RadioButton();
            this.r9B.AutoSize = true;
            this.r9B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r9B.Location = new System.Drawing.Point(20, 70);
            this.r9B.Name = "r9B";
            this.r9B.Size = new System.Drawing.Size(222, 32);
            this.r9B.Text = "B. Een .txt bestand";
            this.r9B.UseVisualStyleBackColor = true;

            this.r9C = new System.Windows.Forms.RadioButton();
            this.r9C.AutoSize = true;
            this.r9C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r9C.Location = new System.Drawing.Point(20, 100);
            this.r9C.Name = "r9C";
            this.r9C.Size = new System.Drawing.Size(164, 32);
            this.r9C.Text = "C. Een foto";
            this.r9C.UseVisualStyleBackColor = true;

            this.grp9.Controls.Add(this.r9A);
            this.grp9.Controls.Add(this.r9B);
            this.grp9.Controls.Add(this.r9C);

            // Vraag 10
            this.grp10 = new System.Windows.Forms.GroupBox();
            this.grp10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.grp10.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.grp10.Location = new System.Drawing.Point(20, 230);
            this.grp10.Name = "grp10";
            this.grp10.Size = new System.Drawing.Size(860, 140);
            this.grp10.TabStop = false;
            this.grp10.Text = "10. Moderne phishingmails zijn vaak…";

            this.r10A = new System.Windows.Forms.RadioButton();
            this.r10A.AutoSize = true;
            this.r10A.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r10A.Location = new System.Drawing.Point(20, 40);
            this.r10A.Name = "r10A";
            this.r10A.Size = new System.Drawing.Size(249, 32);
            this.r10A.Text = "A. Altijd vol spelfouten";
            this.r10A.UseVisualStyleBackColor = true;

            this.r10B = new System.Windows.Forms.RadioButton();
            this.r10B.AutoSize = true;
            this.r10B.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r10B.Location = new System.Drawing.Point(20, 70);
            this.r10B.Name = "r10B";
            this.r10B.Size = new System.Drawing.Size(514, 32);
            this.r10B.Text = "B. Steeds professioneler en lijken echt";
            this.r10B.UseVisualStyleBackColor = true;

            this.r10C = new System.Windows.Forms.RadioButton();
            this.r10C.AutoSize = true;
            this.r10C.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
            this.r10C.Location = new System.Drawing.Point(20, 100);
            this.r10C.Name = "r10C";
            this.r10C.Size = new System.Drawing.Size(312, 32);
            this.r10C.Text = "C. Altijd zonder logo";
            this.r10C.UseVisualStyleBackColor = true;

            this.grp10.Controls.Add(this.r10A);
            this.grp10.Controls.Add(this.r10B);
            this.grp10.Controls.Add(this.r10C);

            // Label voor check message
            this.lblCheckMessage = new System.Windows.Forms.Label();
            this.lblCheckMessage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.lblCheckMessage.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblCheckMessage.Location = new System.Drawing.Point(20, 560);
            this.lblCheckMessage.Name = "lblCheckMessage";
            this.lblCheckMessage.Size = new System.Drawing.Size(860, 40);
            this.lblCheckMessage.Text = "";

            // Controleer antwoorden knop
            this.btnCheckAnswers = new System.Windows.Forms.Button();
            this.btnCheckAnswers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCheckAnswers.ForeColor = System.Drawing.Color.White;
            this.btnCheckAnswers.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnCheckAnswers.Location = new System.Drawing.Point(20, 620);
            this.btnCheckAnswers.Name = "btnCheckAnswers";
            this.btnCheckAnswers.Size = new System.Drawing.Size(400, 60);
            this.btnCheckAnswers.Text = "Controleer antwoorden";
            this.btnCheckAnswers.UseVisualStyleBackColor = false;
            this.btnCheckAnswers.Click += new System.EventHandler(this.btnCheckAnswers_Click);

            // Navigatieknoppen voor pagina5
            this.btnBack5 = new System.Windows.Forms.Button();
            this.btnBack5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnBack5.ForeColor = System.Drawing.Color.White;
            this.btnBack5.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnBack5.Location = new System.Drawing.Point(20, 700);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(150, 60);
            this.btnBack5.Text = "← Vorige";
            this.btnBack5.UseVisualStyleBackColor = false;
            this.btnBack5.Click += new System.EventHandler(this.btnBack5_Click);

            this.btnNext5 = new System.Windows.Forms.Button();
            this.btnNext5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnNext5.ForeColor = System.Drawing.Color.White;
            this.btnNext5.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnNext5.Location = new System.Drawing.Point(730, 700);
            this.btnNext5.Name = "btnNext5";
            this.btnNext5.Size = new System.Drawing.Size(150, 60);
            this.btnNext5.Text = "Volgende →";
            this.btnNext5.UseVisualStyleBackColor = false;
            this.btnNext5.Enabled = false;
            this.btnNext5.Click += new System.EventHandler(this.btnNext5_Click);

            // Voeg controls toe aan pagina5
            this.page5.Controls.Add(this.lblTitle5);
            this.page5.Controls.Add(this.grp9);
            this.page5.Controls.Add(this.grp10);
            this.page5.Controls.Add(this.lblCheckMessage);
            this.page5.Controls.Add(this.btnCheckAnswers);
            this.page5.Controls.Add(this.btnBack5);
            this.page5.Controls.Add(this.btnNext5);

            // Pagina 6 (resultaat)
            this.page6 = new System.Windows.Forms.Panel();
            this.page6.BackColor = System.Drawing.Color.White;
            this.page6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page6.Location = new System.Drawing.Point(50, 50);
            this.page6.Name = "page6";
            this.page6.Size = new System.Drawing.Size(900, 820);
            this.page6.TabIndex = 5;

            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle6.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle6.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblTitle6.Location = new System.Drawing.Point(20, 20);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(860, 50);
            this.lblTitle6.Text = "Resultaat";
            this.lblTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblScore = new System.Windows.Forms.Label();
            this.lblScore.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblScore.Location = new System.Drawing.Point(20, 120);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(860, 60);
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblResultMessage = new System.Windows.Forms.Label();
            this.lblResultMessage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic);
            this.lblResultMessage.ForeColor = System.Drawing.Color.FromArgb(27, 54, 93);
            this.lblResultMessage.Location = new System.Drawing.Point(20, 200);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(860, 100);
            this.lblResultMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            // Button om opnieuw te starten
            this.btnRetake = new System.Windows.Forms.Button();
            this.btnRetake.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnRetake.ForeColor = System.Drawing.Color.White;
            this.btnRetake.BackColor = System.Drawing.Color.FromArgb(27, 53, 93);
            this.btnRetake.Location = new System.Drawing.Point(20, 320);
            this.btnRetake.Name = "btnRetake";
            this.btnRetake.Size = new System.Drawing.Size(300, 70);
            this.btnRetake.Text = "Opnieuw";
            this.btnRetake.UseVisualStyleBackColor = false;
            this.btnRetake.Click += new System.EventHandler(this.btnRetake_Click);

            // Voeg controls toe aan pagina6
            this.page6.Controls.Add(this.lblTitle6);
            this.page6.Controls.Add(this.lblScore);
            this.page6.Controls.Add(this.lblResultMessage);
            this.page6.Controls.Add(this.btnRetake);

            // Voeg alle pagina's toe aan de form (but only page1 initially visible)
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page3);
            this.Controls.Add(this.page4);
            this.Controls.Add(this.page5);
            this.Controls.Add(this.page6);
            // Verborgen bij start; wordt getoond via ShowPage()
            this.page2.Visible = false;
            this.page3.Visible = false;
            this.page4.Visible = false;
            this.page5.Visible = false;
            this.page6.Visible = false;
        }
        #endregion
    }
}