namespace cifrario_cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cifra = new System.Windows.Forms.Button();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_cifrario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(289, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(232, 39);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Cifrario di Cesare";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_cifra
            // 
            this.btn_cifra.Location = new System.Drawing.Point(363, 235);
            this.btn_cifra.Name = "btn_cifra";
            this.btn_cifra.Size = new System.Drawing.Size(94, 36);
            this.btn_cifra.TabIndex = 2;
            this.btn_cifra.Text = "CIFRA";
            this.btn_cifra.UseVisualStyleBackColor = true;
            this.btn_cifra.Click += new System.EventHandler(this.btn_cifra_Click);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(332, 87);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(145, 24);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Inserire la frase";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(332, 173);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(159, 24);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "Inserire la chiave";
            // 
            // lbl_cifrario
            // 
            this.lbl_cifrario.AutoSize = true;
            this.lbl_cifrario.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cifrario.Location = new System.Drawing.Point(336, 274);
            this.lbl_cifrario.Name = "lbl_cifrario";
            this.lbl_cifrario.Size = new System.Drawing.Size(141, 24);
            this.lbl_cifrario.TabIndex = 6;
            this.lbl_cifrario.Text = "*frase criptata*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cifrario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.btn_cifra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cifra;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_cifrario;
        private System.Windows.Forms.TextBox textBox2;
    }
}

