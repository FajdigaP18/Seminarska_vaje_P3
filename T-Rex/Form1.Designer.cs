namespace T_Rex
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tocke = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rex = new System.Windows.Forms.PictureBox();
            this.ovira1 = new System.Windows.Forms.PictureBox();
            this.ovira2 = new System.Windows.Forms.PictureBox();
            this.Najboljsirez = new System.Windows.Forms.Label();
            this.casovnik = new System.Windows.Forms.Timer(this.components);
            this.Ime = new System.Windows.Forms.Label();
            this.Uporabnik = new System.Windows.Forms.TextBox();
            this.Zacni = new System.Windows.Forms.Button();
            this.Rezultati = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Točke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(384, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Najboljši rezultat:";
            // 
            // tocke
            // 
            this.tocke.AutoSize = true;
            this.tocke.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tocke.Location = new System.Drawing.Point(58, 87);
            this.tocke.Name = "tocke";
            this.tocke.Size = new System.Drawing.Size(29, 35);
            this.tocke.TabIndex = 10;
            this.tocke.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(2, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // rex
            // 
            this.rex.Image = global::T_Rex.Properties.Resources.running;
            this.rex.Location = new System.Drawing.Point(89, 345);
            this.rex.Name = "rex";
            this.rex.Size = new System.Drawing.Size(48, 59);
            this.rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rex.TabIndex = 12;
            this.rex.TabStop = false;
            // 
            // ovira1
            // 
            this.ovira1.Image = global::T_Rex.Properties.Resources.obstacle_2;
            this.ovira1.Location = new System.Drawing.Point(466, 367);
            this.ovira1.Name = "ovira1";
            this.ovira1.Size = new System.Drawing.Size(40, 37);
            this.ovira1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovira1.TabIndex = 13;
            this.ovira1.TabStop = false;
            this.ovira1.Tag = "ovira";
            // 
            // ovira2
            // 
            this.ovira2.Image = global::T_Rex.Properties.Resources.obstacle_1;
            this.ovira2.Location = new System.Drawing.Point(708, 345);
            this.ovira2.Name = "ovira2";
            this.ovira2.Size = new System.Drawing.Size(34, 59);
            this.ovira2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovira2.TabIndex = 14;
            this.ovira2.TabStop = false;
            this.ovira2.Tag = "ovira";
            // 
            // Najboljsirez
            // 
            this.Najboljsirez.AutoSize = true;
            this.Najboljsirez.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Najboljsirez.Location = new System.Drawing.Point(626, 40);
            this.Najboljsirez.Name = "Najboljsirez";
            this.Najboljsirez.Size = new System.Drawing.Size(0, 35);
            this.Najboljsirez.TabIndex = 15;
            // 
            // casovnik
            // 
            this.casovnik.Interval = 20;
            this.casovnik.Tick += new System.EventHandler(this.casovnik_Tick);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ime.Location = new System.Drawing.Point(58, 166);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(160, 35);
            this.Ime.TabIndex = 16;
            this.Ime.Text = "Vnesite ime:";
            // 
            // Uporabnik
            // 
            this.Uporabnik.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uporabnik.Location = new System.Drawing.Point(238, 166);
            this.Uporabnik.Name = "Uporabnik";
            this.Uporabnik.Size = new System.Drawing.Size(154, 40);
            this.Uporabnik.TabIndex = 17;
            // 
            // Zacni
            // 
            this.Zacni.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zacni.Location = new System.Drawing.Point(306, 261);
            this.Zacni.Name = "Zacni";
            this.Zacni.Size = new System.Drawing.Size(86, 47);
            this.Zacni.TabIndex = 18;
            this.Zacni.Text = "Začni";
            this.Zacni.UseVisualStyleBackColor = true;
            this.Zacni.Click += new System.EventHandler(this.Zacni_Click);
            // 
            // Rezultati
            // 
            this.Rezultati.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rezultati.FormattingEnabled = true;
            this.Rezultati.ItemHeight = 22;
            this.Rezultati.Location = new System.Drawing.Point(546, 143);
            this.Rezultati.Name = "Rezultati";
            this.Rezultati.Size = new System.Drawing.Size(233, 180);
            this.Rezultati.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rezultati);
            this.Controls.Add(this.Zacni);
            this.Controls.Add(this.Uporabnik);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.Najboljsirez);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ovira2);
            this.Controls.Add(this.ovira1);
            this.Controls.Add(this.rex);
            this.Controls.Add(this.tocke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "T_Rex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovira2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tocke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox rex;
        private System.Windows.Forms.PictureBox ovira1;
        private System.Windows.Forms.PictureBox ovira2;
        private System.Windows.Forms.Label Najboljsirez;
        private System.Windows.Forms.Timer casovnik;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox Uporabnik;
        private System.Windows.Forms.Button Zacni;
        private System.Windows.Forms.ListBox Rezultati;
    }
}

