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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_decripta = new System.Windows.Forms.Label();
            this.txt_chiave2 = new System.Windows.Forms.TextBox();
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
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(247, 114);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(315, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_cifra
            // 
            this.btn_cifra.Location = new System.Drawing.Point(363, 235);
            this.btn_cifra.Name = "btn_cifra";
            this.btn_cifra.Size = new System.Drawing.Size(94, 36);
            this.btn_cifra.TabIndex = 2;
            this.btn_cifra.Text = "CRIPTA";
            this.btn_cifra.UseVisualStyleBackColor = true;
            this.btn_cifra.Click += new System.EventHandler(this.btn_cifra_Click);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(292, 87);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(242, 24);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Inserire la frase da criptare";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(332, 161);
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
            // txt_chiave
            // 
            this.txt_chiave.Location = new System.Drawing.Point(392, 200);
            this.txt_chiave.Name = "txt_chiave";
            this.txt_chiave.Size = new System.Drawing.Size(38, 20);
            this.txt_chiave.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inserire la frase da decriptare";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(247, 352);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(343, 20);
            this.txt_n2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserire la chiave";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "DECRIPTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_decripta
            // 
            this.lbl_decripta.AutoSize = true;
            this.lbl_decripta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decripta.Location = new System.Drawing.Point(336, 484);
            this.lbl_decripta.Name = "lbl_decripta";
            this.lbl_decripta.Size = new System.Drawing.Size(159, 24);
            this.lbl_decripta.TabIndex = 11;
            this.lbl_decripta.Text = "*frase decriptata*";
            // 
            // txt_chiave2
            // 
            this.txt_chiave2.Location = new System.Drawing.Point(392, 420);
            this.txt_chiave2.Name = "txt_chiave2";
            this.txt_chiave2.Size = new System.Drawing.Size(38, 20);
            this.txt_chiave2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.txt_chiave2);
            this.Controls.Add(this.lbl_decripta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_decripta;
        private System.Windows.Forms.TextBox txt_chiave2;
    }
}

