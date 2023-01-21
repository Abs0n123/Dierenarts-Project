namespace Dierenarts_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pbxFoto1 = new System.Windows.Forms.PictureBox();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFoto1
            // 
            this.pbxFoto1.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto1.Image")));
            this.pbxFoto1.Location = new System.Drawing.Point(467, 12);
            this.pbxFoto1.Name = "pbxFoto1";
            this.pbxFoto1.Size = new System.Drawing.Size(303, 404);
            this.pbxFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto1.TabIndex = 0;
            this.pbxFoto1.TabStop = false;
            // 
            // btnKlanten
            // 
            this.btnKlanten.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKlanten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlanten.Location = new System.Drawing.Point(12, 105);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(331, 311);
            this.btnKlanten.TabIndex = 1;
            this.btnKlanten.Text = "Overzicht Klanten";
            this.btnKlanten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlanten.UseVisualStyleBackColor = false;
            this.btnKlanten.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dierenarts Royal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.pbxFoto1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFoto1;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Label label1;
    }
}