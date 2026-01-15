namespace JABASH_SeniorShield.View
{
    partial class frmPhishingDetector
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
            this.tx = new System.Windows.Forms.Panel();
            this.btnAfzender = new System.Windows.Forms.Button();
            this.btnMailInhoud = new System.Windows.Forms.Button();
            this.txtAfzender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlResultaat = new System.Windows.Forms.Panel();
            this.txtResultaatTekst = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnControleren = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx.SuspendLayout();
            this.pnlResultaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx
            // 
            this.tx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tx.BackColor = System.Drawing.Color.White;
            this.tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx.Controls.Add(this.btnAfzender);
            this.tx.Controls.Add(this.btnMailInhoud);
            this.tx.Controls.Add(this.txtAfzender);
            this.tx.Controls.Add(this.label4);
            this.tx.Controls.Add(this.pnlResultaat);
            this.tx.Controls.Add(this.txtMail);
            this.tx.Controls.Add(this.btnControleren);
            this.tx.Controls.Add(this.label3);
            this.tx.Controls.Add(this.label2);
            this.tx.Controls.Add(this.label1);
            this.tx.Location = new System.Drawing.Point(35, -93);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(727, 848);
            this.tx.TabIndex = 1;
            // 
            // btnAfzender
            // 
            this.btnAfzender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnAfzender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfzender.ForeColor = System.Drawing.Color.White;
            this.btnAfzender.Location = new System.Drawing.Point(482, 91);
            this.btnAfzender.Name = "btnAfzender";
            this.btnAfzender.Size = new System.Drawing.Size(209, 34);
            this.btnAfzender.TabIndex = 12;
            this.btnAfzender.Text = "Afzender leegmaken";
            this.btnAfzender.UseVisualStyleBackColor = false;
            this.btnAfzender.Click += new System.EventHandler(this.btnAfzender_Click);
            // 
            // btnMailInhoud
            // 
            this.btnMailInhoud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnMailInhoud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailInhoud.ForeColor = System.Drawing.Color.White;
            this.btnMailInhoud.Location = new System.Drawing.Point(482, 205);
            this.btnMailInhoud.Name = "btnMailInhoud";
            this.btnMailInhoud.Size = new System.Drawing.Size(209, 34);
            this.btnMailInhoud.TabIndex = 11;
            this.btnMailInhoud.Text = "Mail inhoud leegmaken";
            this.btnMailInhoud.UseVisualStyleBackColor = false;
            this.btnMailInhoud.Click += new System.EventHandler(this.btnMailInhoud_Click);
            // 
            // txtAfzender
            // 
            this.txtAfzender.BackColor = System.Drawing.SystemColors.Window;
            this.txtAfzender.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfzender.Location = new System.Drawing.Point(35, 134);
            this.txtAfzender.Name = "txtAfzender";
            this.txtAfzender.Size = new System.Drawing.Size(656, 50);
            this.txtAfzender.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Afzender:";
            // 
            // pnlResultaat
            // 
            this.pnlResultaat.BackColor = System.Drawing.Color.White;
            this.pnlResultaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultaat.Controls.Add(this.txtResultaatTekst);
            this.pnlResultaat.Location = new System.Drawing.Point(35, 682);
            this.pnlResultaat.Name = "pnlResultaat";
            this.pnlResultaat.Size = new System.Drawing.Size(656, 141);
            this.pnlResultaat.TabIndex = 8;
            // 
            // txtResultaatTekst
            // 
            this.txtResultaatTekst.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaatTekst.Location = new System.Drawing.Point(-1, 0);
            this.txtResultaatTekst.Name = "txtResultaatTekst";
            this.txtResultaatTekst.Size = new System.Drawing.Size(656, 139);
            this.txtResultaatTekst.TabIndex = 3;
            this.txtResultaatTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(35, 248);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMail.Size = new System.Drawing.Size(656, 304);
            this.txtMail.TabIndex = 4;
            // 
            // btnControleren
            // 
            this.btnControleren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnControleren.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleren.ForeColor = System.Drawing.Color.White;
            this.btnControleren.Location = new System.Drawing.Point(35, 581);
            this.btnControleren.Name = "btnControleren";
            this.btnControleren.Size = new System.Drawing.Size(656, 80);
            this.btnControleren.TabIndex = 6;
            this.btnControleren.Text = "Mail Controleren";
            this.btnControleren.UseVisualStyleBackColor = false;
            this.btnControleren.Click += new System.EventHandler(this.btnControleren_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plak hier uw verdachte mailinhoud:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(-1, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 2);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 9, 0, 0);
            this.label1.Size = new System.Drawing.Size(726, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phishing Detector";
            // 
            // frmPhishingDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.tx);
            this.Name = "frmPhishingDetector";
            this.Text = "Phishing Detector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhishingDetector_Load);
            this.tx.ResumeLayout(false);
            this.tx.PerformLayout();
            this.pnlResultaat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tx;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnControleren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlResultaat;
        private System.Windows.Forms.Label txtResultaatTekst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAfzender;
        private System.Windows.Forms.Button btnMailInhoud;
        private System.Windows.Forms.Button btnAfzender;
    }
}