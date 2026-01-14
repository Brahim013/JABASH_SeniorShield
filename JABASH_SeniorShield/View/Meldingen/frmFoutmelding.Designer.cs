namespace JABASH_SeniorShield.View.Meldingen
{
    partial class frmFoutmelding
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
            this.lblBericht = new System.Windows.Forms.Label();
            this.btnBegrepen = new System.Windows.Forms.Button();
            this.lblIcoon = new System.Windows.Forms.Label();
            this.pnlBericht = new System.Windows.Forms.Panel();
            this.pnlBericht.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBericht
            // 
            this.lblBericht.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBericht.Location = new System.Drawing.Point(-4, 67);
            this.lblBericht.Name = "lblBericht";
            this.lblBericht.Size = new System.Drawing.Size(484, 113);
            this.lblBericht.TabIndex = 0;
            this.lblBericht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBegrepen
            // 
            this.btnBegrepen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.btnBegrepen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegrepen.ForeColor = System.Drawing.Color.White;
            this.btnBegrepen.Location = new System.Drawing.Point(121, 189);
            this.btnBegrepen.Name = "btnBegrepen";
            this.btnBegrepen.Size = new System.Drawing.Size(219, 59);
            this.btnBegrepen.TabIndex = 7;
            this.btnBegrepen.Text = "Begrepen";
            this.btnBegrepen.UseVisualStyleBackColor = false;
            this.btnBegrepen.Click += new System.EventHandler(this.btnBegrepen_Click);
            // 
            // lblIcoon
            // 
            this.lblIcoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIcoon.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcoon.Location = new System.Drawing.Point(0, 0);
            this.lblIcoon.Name = "lblIcoon";
            this.lblIcoon.Size = new System.Drawing.Size(480, 49);
            this.lblIcoon.TabIndex = 8;
            this.lblIcoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBericht
            // 
            this.pnlBericht.Controls.Add(this.btnBegrepen);
            this.pnlBericht.Controls.Add(this.lblBericht);
            this.pnlBericht.Controls.Add(this.lblIcoon);
            this.pnlBericht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBericht.Location = new System.Drawing.Point(2, 2);
            this.pnlBericht.Name = "pnlBericht";
            this.pnlBericht.Size = new System.Drawing.Size(480, 257);
            this.pnlBericht.TabIndex = 9;
            // 
            // frmFoutmelding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pnlBericht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFoutmelding";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFoutmelding";
            this.Load += new System.EventHandler(this.frmFoutmelding_Load);
            this.pnlBericht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBericht;
        private System.Windows.Forms.Button btnBegrepen;
        private System.Windows.Forms.Label lblIcoon;
        private System.Windows.Forms.Panel pnlBericht;
    }
}