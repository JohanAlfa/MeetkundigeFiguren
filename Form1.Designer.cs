namespace MeetkundigeFiguren
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
            this.lblOppervlakte = new System.Windows.Forms.Label();
            this.lblOmtrek = new System.Windows.Forms.Label();
            this.btnTeken = new System.Windows.Forms.Button();
            this.txtStraal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLijndikte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKleur = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOppervlakte
            // 
            this.lblOppervlakte.AutoSize = true;
            this.lblOppervlakte.Location = new System.Drawing.Point(12, 9);
            this.lblOppervlakte.Name = "lblOppervlakte";
            this.lblOppervlakte.Size = new System.Drawing.Size(78, 13);
            this.lblOppervlakte.TabIndex = 0;
            this.lblOppervlakte.Text = "Oppervlakte is ";
            // 
            // lblOmtrek
            // 
            this.lblOmtrek.AutoSize = true;
            this.lblOmtrek.Location = new System.Drawing.Point(12, 34);
            this.lblOmtrek.Name = "lblOmtrek";
            this.lblOmtrek.Size = new System.Drawing.Size(54, 13);
            this.lblOmtrek.TabIndex = 1;
            this.lblOmtrek.Text = "Omtrek is ";
            // 
            // btnTeken
            // 
            this.btnTeken.Location = new System.Drawing.Point(15, 60);
            this.btnTeken.Name = "btnTeken";
            this.btnTeken.Size = new System.Drawing.Size(75, 23);
            this.btnTeken.TabIndex = 2;
            this.btnTeken.Text = "Teken";
            this.btnTeken.UseVisualStyleBackColor = true;
            this.btnTeken.Click += new System.EventHandler(this.btnTeken_Click);
            // 
            // txtStraal
            // 
            this.txtStraal.Location = new System.Drawing.Point(438, 9);
            this.txtStraal.Name = "txtStraal";
            this.txtStraal.Size = new System.Drawing.Size(36, 20);
            this.txtStraal.TabIndex = 3;
            this.txtStraal.TextChanged += new System.EventHandler(this.txtStraal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Straal";
            // 
            // txtLijndikte
            // 
            this.txtLijndikte.Location = new System.Drawing.Point(438, 31);
            this.txtLijndikte.Name = "txtLijndikte";
            this.txtLijndikte.Size = new System.Drawing.Size(36, 20);
            this.txtLijndikte.TabIndex = 3;
            this.txtLijndikte.TextChanged += new System.EventHandler(this.txtLijndikte_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lijndikte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kleur";
            // 
            // btnKleur
            // 
            this.btnKleur.Location = new System.Drawing.Point(438, 56);
            this.btnKleur.Name = "btnKleur";
            this.btnKleur.Size = new System.Drawing.Size(36, 20);
            this.btnKleur.TabIndex = 5;
            this.btnKleur.Text = "...";
            this.btnKleur.UseVisualStyleBackColor = true;
            this.btnKleur.Click += new System.EventHandler(this.btnKleur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(13, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 309);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKleur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLijndikte);
            this.Controls.Add(this.txtStraal);
            this.Controls.Add(this.btnTeken);
            this.Controls.Add(this.lblOmtrek);
            this.Controls.Add(this.lblOppervlakte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOppervlakte;
        private System.Windows.Forms.Label lblOmtrek;
        private System.Windows.Forms.Button btnTeken;
        private System.Windows.Forms.TextBox txtStraal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLijndikte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKleur;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

