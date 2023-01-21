namespace Dierenarts_Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxKlanten = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWijzigen = new System.Windows.Forms.Button();
            this.lbxHandelingen = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblHandeling = new System.Windows.Forms.Label();
            this.txtHandeling = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klanten overzicht - Dierenarts Royal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 388);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(231, 50);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Gegevens toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(269, 388);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(231, 50);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Terug naar homepagina";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.Location = new System.Drawing.Point(269, 69);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.ReadOnly = true;
            this.txtVoornaam.Size = new System.Drawing.Size(210, 34);
            this.txtVoornaam.TabIndex = 6;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchternaam.Location = new System.Drawing.Point(269, 138);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.ReadOnly = true;
            this.txtAchternaam.Size = new System.Drawing.Size(210, 34);
            this.txtAchternaam.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(269, 203);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(210, 34);
            this.txtAdres.TabIndex = 8;
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWoonplaats.Location = new System.Drawing.Point(269, 274);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.ReadOnly = true;
            this.txtWoonplaats.Size = new System.Drawing.Size(210, 34);
            this.txtWoonplaats.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Woonplaats";
            // 
            // lbxKlanten
            // 
            this.lbxKlanten.FormattingEnabled = true;
            this.lbxKlanten.ItemHeight = 16;
            this.lbxKlanten.Location = new System.Drawing.Point(12, 69);
            this.lbxKlanten.Name = "lbxKlanten";
            this.lbxKlanten.Size = new System.Drawing.Size(228, 260);
            this.lbxKlanten.TabIndex = 14;
            this.lbxKlanten.SelectedIndexChanged += new System.EventHandler(this.lbxKlanten_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Overzicht klanten";
            // 
            // txtWijzigen
            // 
            this.txtWijzigen.Location = new System.Drawing.Point(269, 332);
            this.txtWijzigen.Name = "txtWijzigen";
            this.txtWijzigen.Size = new System.Drawing.Size(231, 50);
            this.txtWijzigen.TabIndex = 16;
            this.txtWijzigen.Text = "Wijzigen gegevens";
            this.txtWijzigen.UseVisualStyleBackColor = true;
            this.txtWijzigen.Click += new System.EventHandler(this.txtWijzigen_Click);
            // 
            // lbxHandelingen
            // 
            this.lbxHandelingen.FormattingEnabled = true;
            this.lbxHandelingen.ItemHeight = 16;
            this.lbxHandelingen.Location = new System.Drawing.Point(523, 59);
            this.lbxHandelingen.Name = "lbxHandelingen";
            this.lbxHandelingen.Size = new System.Drawing.Size(228, 180);
            this.lbxHandelingen.TabIndex = 17;
            this.lbxHandelingen.SelectedIndexChanged += new System.EventHandler(this.lbxHandelingen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Handelingen";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(254, 0);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 34);
            this.txtId.TabIndex = 19;
            // 
            // lblHandeling
            // 
            this.lblHandeling.AutoSize = true;
            this.lblHandeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandeling.Location = new System.Drawing.Point(508, 245);
            this.lblHandeling.Name = "lblHandeling";
            this.lblHandeling.Size = new System.Drawing.Size(203, 24);
            this.lblHandeling.TabIndex = 20;
            this.lblHandeling.Text = "Aantal handelingen :";
            // 
            // txtHandeling
            // 
            this.txtHandeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHandeling.Location = new System.Drawing.Point(712, 245);
            this.txtHandeling.Name = "txtHandeling";
            this.txtHandeling.ReadOnly = true;
            this.txtHandeling.Size = new System.Drawing.Size(39, 28);
            this.txtHandeling.TabIndex = 21;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.txtHandeling);
            this.Controls.Add(this.lblHandeling);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxHandelingen);
            this.Controls.Add(this.txtWijzigen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxKlanten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWoonplaats);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxKlanten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtWijzigen;
        private System.Windows.Forms.ListBox lbxHandelingen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblHandeling;
        private System.Windows.Forms.TextBox txtHandeling;
    }
}