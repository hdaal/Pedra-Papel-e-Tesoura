namespace ppt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pedra = new System.Windows.Forms.PictureBox();
            this.papel = new System.Windows.Forms.PictureBox();
            this.tesoura = new System.Windows.Forms.PictureBox();
            this.itesoura = new System.Windows.Forms.PictureBox();
            this.ipapel = new System.Windows.Forms.PictureBox();
            this.ipedra = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plac = new System.Windows.Forms.Label();
            this.plac2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipedra)).BeginInit();
            this.SuspendLayout();
            // 
            // pedra
            // 
            this.pedra.Image = ((System.Drawing.Image)(resources.GetObject("pedra.Image")));
            this.pedra.Location = new System.Drawing.Point(30, 315);
            this.pedra.Name = "pedra";
            this.pedra.Size = new System.Drawing.Size(130, 130);
            this.pedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pedra.TabIndex = 0;
            this.pedra.TabStop = false;
            this.pedra.Click += new System.EventHandler(this.pedra_Click);
            // 
            // papel
            // 
            this.papel.Image = ((System.Drawing.Image)(resources.GetObject("papel.Image")));
            this.papel.Location = new System.Drawing.Point(190, 315);
            this.papel.Name = "papel";
            this.papel.Size = new System.Drawing.Size(130, 130);
            this.papel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.papel.TabIndex = 1;
            this.papel.TabStop = false;
            this.papel.Click += new System.EventHandler(this.papel_Click);
            // 
            // tesoura
            // 
            this.tesoura.Image = ((System.Drawing.Image)(resources.GetObject("tesoura.Image")));
            this.tesoura.Location = new System.Drawing.Point(350, 315);
            this.tesoura.Name = "tesoura";
            this.tesoura.Size = new System.Drawing.Size(130, 130);
            this.tesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tesoura.TabIndex = 2;
            this.tesoura.TabStop = false;
            this.tesoura.Click += new System.EventHandler(this.tesoura_Click);
            // 
            // itesoura
            // 
            this.itesoura.Image = ((System.Drawing.Image)(resources.GetObject("itesoura.Image")));
            this.itesoura.Location = new System.Drawing.Point(350, 30);
            this.itesoura.Name = "itesoura";
            this.itesoura.Size = new System.Drawing.Size(130, 130);
            this.itesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.itesoura.TabIndex = 5;
            this.itesoura.TabStop = false;
            // 
            // ipapel
            // 
            this.ipapel.Image = ((System.Drawing.Image)(resources.GetObject("ipapel.Image")));
            this.ipapel.Location = new System.Drawing.Point(190, 30);
            this.ipapel.Name = "ipapel";
            this.ipapel.Size = new System.Drawing.Size(130, 130);
            this.ipapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipapel.TabIndex = 4;
            this.ipapel.TabStop = false;
            // 
            // ipedra
            // 
            this.ipedra.Image = ((System.Drawing.Image)(resources.GetObject("ipedra.Image")));
            this.ipedra.Location = new System.Drawing.Point(30, 30);
            this.ipedra.Name = "ipedra";
            this.ipedra.Size = new System.Drawing.Size(130, 130);
            this.ipedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipedra.TabIndex = 3;
            this.ipedra.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(30, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 130);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(350, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 130);
            this.panel2.TabIndex = 8;
            // 
            // plac
            // 
            this.plac.AutoSize = true;
            this.plac.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.plac.Location = new System.Drawing.Point(183, 184);
            this.plac.Name = "plac";
            this.plac.Size = new System.Drawing.Size(40, 42);
            this.plac.TabIndex = 9;
            this.plac.Text = "0";
            // 
            // plac2
            // 
            this.plac2.AutoSize = true;
            this.plac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.plac2.Location = new System.Drawing.Point(292, 184);
            this.plac2.Name = "plac2";
            this.plac2.Size = new System.Drawing.Size(40, 42);
            this.plac2.TabIndex = 10;
            this.plac2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ZERAR PLACAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plac2);
            this.Controls.Add(this.plac);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itesoura);
            this.Controls.Add(this.ipapel);
            this.Controls.Add(this.ipedra);
            this.Controls.Add(this.tesoura);
            this.Controls.Add(this.papel);
            this.Controls.Add(this.pedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pedra, Papel e Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pedra;
        private System.Windows.Forms.PictureBox papel;
        private System.Windows.Forms.PictureBox tesoura;
        private System.Windows.Forms.PictureBox itesoura;
        private System.Windows.Forms.PictureBox ipapel;
        private System.Windows.Forms.PictureBox ipedra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label plac;
        private System.Windows.Forms.Label plac2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

