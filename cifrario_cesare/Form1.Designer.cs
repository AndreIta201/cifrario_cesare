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
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_cifra = new System.Windows.Forms.Button();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_cifrario = new System.Windows.Forms.Label();
            this.txt_chiave = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.btn_decripta = new System.Windows.Forms.Button();
            this.lbl_decripta = new System.Windows.Forms.Label();
            this.txt_chiave2 = new System.Windows.Forms.TextBox();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.btn_cripta2 = new System.Windows.Forms.Button();
            this.lbl_criptaggio_parola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_decripta2 = new System.Windows.Forms.Button();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.txt_decriptaggio_parola = new System.Windows.Forms.TextBox();
            this.lbl_decriptaggio_parola = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(88, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(322, 50);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Cifrario di Cesare";
            // 
            // txt_n1
            // 
            this.txt_n1.BackColor = System.Drawing.Color.Thistle;
            this.txt_n1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(247, 92);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(158, 22);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_cifra
            // 
            this.btn_cifra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cifra.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cifra.Location = new System.Drawing.Point(3, 151);
            this.btn_cifra.Name = "btn_cifra";
            this.btn_cifra.Size = new System.Drawing.Size(94, 25);
            this.btn_cifra.TabIndex = 2;
            this.btn_cifra.Text = "CRIPTA";
            this.btn_cifra.UseVisualStyleBackColor = false;
            this.btn_cifra.Click += new System.EventHandler(this.btn_cifra_Click);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(-1, 87);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(234, 24);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Inserire la frase da criptare:";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(-1, 119);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(156, 24);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "Inserire la chiave:";
            // 
            // lbl_cifrario
            // 
            this.lbl_cifrario.AutoSize = true;
            this.lbl_cifrario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cifrario.Location = new System.Drawing.Point(243, 152);
            this.lbl_cifrario.Name = "lbl_cifrario";
            this.lbl_cifrario.Size = new System.Drawing.Size(170, 29);
            this.lbl_cifrario.TabIndex = 6;
            this.lbl_cifrario.Text = "*frase criptata*";
            // 
            // txt_chiave
            // 
            this.txt_chiave.BackColor = System.Drawing.Color.Thistle;
            this.txt_chiave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiave.Location = new System.Drawing.Point(296, 122);
            this.txt_chiave.Name = "txt_chiave";
            this.txt_chiave.Size = new System.Drawing.Size(57, 22);
            this.txt_chiave.TabIndex = 5;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(-1, 247);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(256, 24);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "Inserire la frase da decriptare:";
            // 
            // txt_n2
            // 
            this.txt_n2.BackColor = System.Drawing.Color.Thistle;
            this.txt_n2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n2.Location = new System.Drawing.Point(256, 252);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(149, 22);
            this.txt_n2.TabIndex = 8;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(-1, 274);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(156, 24);
            this.lbl_n5.TabIndex = 9;
            this.lbl_n5.Text = "Inserire la chiave:";
            // 
            // btn_decripta
            // 
            this.btn_decripta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_decripta.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decripta.Location = new System.Drawing.Point(3, 314);
            this.btn_decripta.Name = "btn_decripta";
            this.btn_decripta.Size = new System.Drawing.Size(94, 24);
            this.btn_decripta.TabIndex = 10;
            this.btn_decripta.Text = "DECRIPTA";
            this.btn_decripta.UseVisualStyleBackColor = false;
            this.btn_decripta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_decripta
            // 
            this.lbl_decripta.AutoSize = true;
            this.lbl_decripta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decripta.Location = new System.Drawing.Point(243, 314);
            this.lbl_decripta.Name = "lbl_decripta";
            this.lbl_decripta.Size = new System.Drawing.Size(177, 25);
            this.lbl_decripta.TabIndex = 11;
            this.lbl_decripta.Text = "*frase decriptata*";
            // 
            // txt_chiave2
            // 
            this.txt_chiave2.BackColor = System.Drawing.Color.Thistle;
            this.txt_chiave2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiave2.Location = new System.Drawing.Point(296, 278);
            this.txt_chiave2.Name = "txt_chiave2";
            this.txt_chiave2.Size = new System.Drawing.Size(57, 22);
            this.txt_chiave2.TabIndex = 12;
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.Location = new System.Drawing.Point(559, 89);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(234, 24);
            this.lbl_n6.TabIndex = 13;
            this.lbl_n6.Text = "Inserire la frase da criptare:";
            // 
            // txt_n3
            // 
            this.txt_n3.BackColor = System.Drawing.Color.Thistle;
            this.txt_n3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n3.Location = new System.Drawing.Point(800, 92);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(158, 22);
            this.txt_n3.TabIndex = 14;
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.Location = new System.Drawing.Point(559, 121);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(225, 24);
            this.lbl_n7.TabIndex = 15;
            this.lbl_n7.Text = "Inserire la chiave (parola):";
            // 
            // txt_parola
            // 
            this.txt_parola.BackColor = System.Drawing.Color.Thistle;
            this.txt_parola.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parola.Location = new System.Drawing.Point(825, 122);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(110, 22);
            this.txt_parola.TabIndex = 16;
            // 
            // btn_cripta2
            // 
            this.btn_cripta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cripta2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cripta2.Location = new System.Drawing.Point(563, 151);
            this.btn_cripta2.Name = "btn_cripta2";
            this.btn_cripta2.Size = new System.Drawing.Size(94, 25);
            this.btn_cripta2.TabIndex = 17;
            this.btn_cripta2.Text = "CRIPTA";
            this.btn_cripta2.UseVisualStyleBackColor = false;
            this.btn_cripta2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_criptaggio_parola
            // 
            this.lbl_criptaggio_parola.AutoSize = true;
            this.lbl_criptaggio_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_criptaggio_parola.Location = new System.Drawing.Point(776, 155);
            this.lbl_criptaggio_parola.Name = "lbl_criptaggio_parola";
            this.lbl_criptaggio_parola.Size = new System.Drawing.Size(222, 24);
            this.lbl_criptaggio_parola.TabIndex = 18;
            this.lbl_criptaggio_parola.Text = "*frase criptata con parola*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inserire la frase da decriptare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Inserire la chiave (parola):";
            // 
            // btn_decripta2
            // 
            this.btn_decripta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_decripta2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decripta2.Location = new System.Drawing.Point(563, 313);
            this.btn_decripta2.Name = "btn_decripta2";
            this.btn_decripta2.Size = new System.Drawing.Size(94, 25);
            this.btn_decripta2.TabIndex = 21;
            this.btn_decripta2.Text = "DECRIPTA";
            this.btn_decripta2.UseVisualStyleBackColor = false;
            this.btn_decripta2.Click += new System.EventHandler(this.btn_decripta2_Click);
            // 
            // txt_n4
            // 
            this.txt_n4.BackColor = System.Drawing.Color.Thistle;
            this.txt_n4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n4.Location = new System.Drawing.Point(825, 251);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(158, 22);
            this.txt_n4.TabIndex = 22;
            // 
            // txt_decriptaggio_parola
            // 
            this.txt_decriptaggio_parola.BackColor = System.Drawing.Color.Thistle;
            this.txt_decriptaggio_parola.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decriptaggio_parola.Location = new System.Drawing.Point(839, 277);
            this.txt_decriptaggio_parola.Name = "txt_decriptaggio_parola";
            this.txt_decriptaggio_parola.Size = new System.Drawing.Size(110, 22);
            this.txt_decriptaggio_parola.TabIndex = 23;
            // 
            // lbl_decriptaggio_parola
            // 
            this.lbl_decriptaggio_parola.AutoSize = true;
            this.lbl_decriptaggio_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decriptaggio_parola.Location = new System.Drawing.Point(776, 317);
            this.lbl_decriptaggio_parola.Name = "lbl_decriptaggio_parola";
            this.lbl_decriptaggio_parola.Size = new System.Drawing.Size(244, 24);
            this.lbl_decriptaggio_parola.TabIndex = 24;
            this.lbl_decriptaggio_parola.Text = "*frase decriptata con parola*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 50);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cifrario di Vigénere";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1117, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_decriptaggio_parola);
            this.Controls.Add(this.txt_decriptaggio_parola);
            this.Controls.Add(this.txt_n4);
            this.Controls.Add(this.btn_decripta2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_criptaggio_parola);
            this.Controls.Add(this.btn_cripta2);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.txt_chiave2);
            this.Controls.Add(this.lbl_decripta);
            this.Controls.Add(this.btn_decripta);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.lbl_cifrario);
            this.Controls.Add(this.txt_chiave);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.btn_cifra);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_cifra;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_cifrario;
        private System.Windows.Forms.TextBox txt_chiave;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Button btn_decripta;
        private System.Windows.Forms.Label lbl_decripta;
        private System.Windows.Forms.TextBox txt_chiave2;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Button btn_cripta2;
        private System.Windows.Forms.Label lbl_criptaggio_parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_decripta2;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.TextBox txt_decriptaggio_parola;
        private System.Windows.Forms.Label lbl_decriptaggio_parola;
        private System.Windows.Forms.Label label4;
    }
}

