namespace _2021._09._15
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
            this.btnosszeadas = new System.Windows.Forms.Button();
            this.btnkivonas = new System.Windows.Forms.Button();
            this.btnszorzas = new System.Windows.Forms.Button();
            this.lbladat2 = new System.Windows.Forms.Label();
            this.lbladat1 = new System.Windows.Forms.Label();
            this.textadat2 = new System.Windows.Forms.TextBox();
            this.textadat1 = new System.Windows.Forms.TextBox();
            this.lbleredmeny = new System.Windows.Forms.Label();
            this.texteredmeny = new System.Windows.Forms.TextBox();
            this.lblmuveletosszeadasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnosszeadas
            // 
            this.btnosszeadas.Location = new System.Drawing.Point(55, 258);
            this.btnosszeadas.Name = "btnosszeadas";
            this.btnosszeadas.Size = new System.Drawing.Size(75, 23);
            this.btnosszeadas.TabIndex = 0;
            this.btnosszeadas.Text = "Összeadás";
            this.btnosszeadas.UseVisualStyleBackColor = true;
            this.btnosszeadas.Click += new System.EventHandler(this.Btnosszeadas_Click);
            // 
            // btnkivonas
            // 
            this.btnkivonas.Location = new System.Drawing.Point(55, 303);
            this.btnkivonas.Name = "btnkivonas";
            this.btnkivonas.Size = new System.Drawing.Size(75, 23);
            this.btnkivonas.TabIndex = 1;
            this.btnkivonas.Text = "Kivonás";
            this.btnkivonas.UseVisualStyleBackColor = true;
            // 
            // btnszorzas
            // 
            this.btnszorzas.Location = new System.Drawing.Point(55, 347);
            this.btnszorzas.Name = "btnszorzas";
            this.btnszorzas.Size = new System.Drawing.Size(75, 23);
            this.btnszorzas.TabIndex = 2;
            this.btnszorzas.Text = "Szorzás";
            this.btnszorzas.UseVisualStyleBackColor = true;
            // 
            // lbladat2
            // 
            this.lbladat2.AutoSize = true;
            this.lbladat2.Location = new System.Drawing.Point(55, 222);
            this.lbladat2.Name = "lbladat2";
            this.lbladat2.Size = new System.Drawing.Size(35, 13);
            this.lbladat2.TabIndex = 3;
            this.lbladat2.Text = "Adat2";
            // 
            // lbladat1
            // 
            this.lbladat1.AutoSize = true;
            this.lbladat1.Location = new System.Drawing.Point(55, 188);
            this.lbladat1.Name = "lbladat1";
            this.lbladat1.Size = new System.Drawing.Size(35, 13);
            this.lbladat1.TabIndex = 4;
            this.lbladat1.Text = "Adat1";
            // 
            // textadat2
            // 
            this.textadat2.Location = new System.Drawing.Point(96, 215);
            this.textadat2.Name = "textadat2";
            this.textadat2.Size = new System.Drawing.Size(100, 20);
            this.textadat2.TabIndex = 5;
            // 
            // textadat1
            // 
            this.textadat1.Location = new System.Drawing.Point(96, 180);
            this.textadat1.Name = "textadat1";
            this.textadat1.Size = new System.Drawing.Size(100, 20);
            this.textadat1.TabIndex = 6;
            // 
            // lbleredmeny
            // 
            this.lbleredmeny.AutoSize = true;
            this.lbleredmeny.Location = new System.Drawing.Point(157, 312);
            this.lbleredmeny.Name = "lbleredmeny";
            this.lbleredmeny.Size = new System.Drawing.Size(54, 13);
            this.lbleredmeny.TabIndex = 7;
            this.lbleredmeny.Text = "Eredmény";
            // 
            // texteredmeny
            // 
            this.texteredmeny.Location = new System.Drawing.Point(212, 309);
            this.texteredmeny.Name = "texteredmeny";
            this.texteredmeny.Size = new System.Drawing.Size(100, 20);
            this.texteredmeny.TabIndex = 8;
            // 
            // lblmuveletosszeadasa
            // 
            this.lblmuveletosszeadasa.AutoSize = true;
            this.lblmuveletosszeadasa.Location = new System.Drawing.Point(209, 293);
            this.lblmuveletosszeadasa.Name = "lblmuveletosszeadasa";
            this.lblmuveletosszeadasa.Size = new System.Drawing.Size(104, 13);
            this.lblmuveletosszeadasa.TabIndex = 9;
            this.lblmuveletosszeadasa.Text = "Művelet összeadása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmuveletosszeadasa);
            this.Controls.Add(this.texteredmeny);
            this.Controls.Add(this.lbleredmeny);
            this.Controls.Add(this.textadat1);
            this.Controls.Add(this.textadat2);
            this.Controls.Add(this.lbladat1);
            this.Controls.Add(this.lbladat2);
            this.Controls.Add(this.btnszorzas);
            this.Controls.Add(this.btnkivonas);
            this.Controls.Add(this.btnosszeadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnosszeadas;
        private System.Windows.Forms.Button btnkivonas;
        private System.Windows.Forms.Button btnszorzas;
        private System.Windows.Forms.Label lbladat2;
        private System.Windows.Forms.Label lbladat1;
        private System.Windows.Forms.TextBox textadat2;
        private System.Windows.Forms.TextBox textadat1;
        private System.Windows.Forms.Label lbleredmeny;
        private System.Windows.Forms.TextBox texteredmeny;
        private System.Windows.Forms.Label lblmuveletosszeadasa;
    }
}

