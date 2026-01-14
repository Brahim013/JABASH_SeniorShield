namespace JABASH_SeniorShield.View.Dashboard
{
    partial class frmHoofdmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoofdmenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlInhoud = new System.Windows.Forms.Panel();
            this.btnMailbox = new System.Windows.Forms.Button();
            this.btnPhishingHerkenner = new System.Windows.Forms.Button();
            this.btnAfmelden = new System.Windows.Forms.Button();
            this.btnTips = new System.Windows.Forms.Button();
            this.btnInstellingen = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.logo);
            this.pnlMenu.Controls.Add(this.btnInstellingen);
            this.pnlMenu.Controls.Add(this.btnTips);
            this.pnlMenu.Controls.Add(this.btnAfmelden);
            this.pnlMenu.Controls.Add(this.btnPhishingHerkenner);
            this.pnlMenu.Controls.Add(this.btnMailbox);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(332, 869);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlInhoud
            // 
            this.pnlInhoud.BackColor = System.Drawing.Color.White;
            this.pnlInhoud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInhoud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInhoud.Location = new System.Drawing.Point(332, 0);
            this.pnlInhoud.Name = "pnlInhoud";
            this.pnlInhoud.Size = new System.Drawing.Size(932, 869);
            this.pnlInhoud.TabIndex = 1;
            // 
            // btnMailbox
            // 
            this.btnMailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnMailbox.FlatAppearance.BorderSize = 0;
            this.btnMailbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailbox.ForeColor = System.Drawing.Color.White;
            this.btnMailbox.Location = new System.Drawing.Point(31, 190);
            this.btnMailbox.Name = "btnMailbox";
            this.btnMailbox.Size = new System.Drawing.Size(263, 102);
            this.btnMailbox.TabIndex = 7;
            this.btnMailbox.Text = "Mailbox";
            this.btnMailbox.UseVisualStyleBackColor = false;
            // 
            // btnPhishingHerkenner
            // 
            this.btnPhishingHerkenner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnPhishingHerkenner.FlatAppearance.BorderSize = 0;
            this.btnPhishingHerkenner.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhishingHerkenner.ForeColor = System.Drawing.Color.White;
            this.btnPhishingHerkenner.Location = new System.Drawing.Point(31, 323);
            this.btnPhishingHerkenner.Name = "btnPhishingHerkenner";
            this.btnPhishingHerkenner.Size = new System.Drawing.Size(263, 102);
            this.btnPhishingHerkenner.TabIndex = 8;
            this.btnPhishingHerkenner.Text = "Phishing Herkenner";
            this.btnPhishingHerkenner.UseVisualStyleBackColor = false;
            this.btnPhishingHerkenner.Click += new System.EventHandler(this.btnPhishingHerkenner_Click);
            // 
            // btnAfmelden
            // 
            this.btnAfmelden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnAfmelden.FlatAppearance.BorderSize = 0;
            this.btnAfmelden.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfmelden.ForeColor = System.Drawing.Color.White;
            this.btnAfmelden.Location = new System.Drawing.Point(31, 732);
            this.btnAfmelden.Name = "btnAfmelden";
            this.btnAfmelden.Size = new System.Drawing.Size(263, 102);
            this.btnAfmelden.TabIndex = 10;
            this.btnAfmelden.Text = "Afmelden";
            this.btnAfmelden.UseVisualStyleBackColor = false;
            this.btnAfmelden.Click += new System.EventHandler(this.btnAfmelden_Click);
            // 
            // btnTips
            // 
            this.btnTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnTips.FlatAppearance.BorderSize = 0;
            this.btnTips.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTips.ForeColor = System.Drawing.Color.White;
            this.btnTips.Location = new System.Drawing.Point(31, 459);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(263, 102);
            this.btnTips.TabIndex = 11;
            this.btnTips.Text = "Veiligheidstips";
            this.btnTips.UseVisualStyleBackColor = false;
            // 
            // btnInstellingen
            // 
            this.btnInstellingen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnInstellingen.FlatAppearance.BorderSize = 0;
            this.btnInstellingen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstellingen.ForeColor = System.Drawing.Color.White;
            this.btnInstellingen.Location = new System.Drawing.Point(31, 593);
            this.btnInstellingen.Name = "btnInstellingen";
            this.btnInstellingen.Size = new System.Drawing.Size(263, 102);
            this.btnInstellingen.TabIndex = 12;
            this.btnInstellingen.Text = "Instellingen";
            this.btnInstellingen.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(52, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(222, 173);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // frmHoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1264, 869);
            this.Controls.Add(this.pnlInhoud);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmHoofdmenu";
            this.Text = "JABASH - Senior Shield Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlInhoud;
        private System.Windows.Forms.Button btnMailbox;
        private System.Windows.Forms.Button btnPhishingHerkenner;
        private System.Windows.Forms.Button btnAfmelden;
        private System.Windows.Forms.Button btnInstellingen;
        private System.Windows.Forms.Button btnTips;
        private System.Windows.Forms.PictureBox logo;
    }
}