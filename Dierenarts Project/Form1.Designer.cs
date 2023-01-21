namespace Dierenarts_Project
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(-1, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 20);
            label1.TabIndex = 2;
            label1.Text = "Gebruikersnaam :";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikersnaam.Location = new System.Drawing.Point(191, 39);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(209, 34);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.Location = new System.Drawing.Point(191, 84);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(209, 34);
            this.txtWachtwoord.TabIndex = 1;
            this.txtWachtwoord.TextChanged += new System.EventHandler(this.txtWachtwoord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord :";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(191, 124);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(177, 66);
            this.btnInloggen.TabIndex = 4;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxFoto.InitialImage")));
            this.pbxFoto.Location = new System.Drawing.Point(429, 12);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(267, 314);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 6;
            this.pbxFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(708, 359);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.PictureBox pbxFoto;
    }
}

