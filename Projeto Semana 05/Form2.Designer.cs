namespace Projeto_Semana_05
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
            this.resultMedia = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.btAnalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultMedia
            // 
            this.resultMedia.AutoSize = true;
            this.resultMedia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMedia.Location = new System.Drawing.Point(53, 142);
            this.resultMedia.Name = "resultMedia";
            this.resultMedia.Size = new System.Drawing.Size(193, 19);
            this.resultMedia.TabIndex = 15;
            this.resultMedia.Text = "Seu média aparecerá aqui:";
            this.resultMedia.Click += new System.EventHandler(this.resultMedia_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(275, 167);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(120, 44);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btMedia
            // 
            this.btMedia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedia.Location = new System.Drawing.Point(43, 167);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(168, 44);
            this.btMedia.TabIndex = 13;
            this.btMedia.Text = "Calcular média";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Média do Aluno";
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenome.Location = new System.Drawing.Point(53, 78);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(117, 19);
            this.sobrenome.TabIndex = 11;
            this.sobrenome.Text = "Digite a 2ª nota";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(53, 52);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(117, 19);
            this.nome.TabIndex = 10;
            this.nome.Text = "Digite a 1ª nota";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(173, 78);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(222, 20);
            this.text2.TabIndex = 9;
            this.text2.TextChanged += new System.EventHandler(this.text2_TextChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(173, 52);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(222, 20);
            this.text1.TabIndex = 8;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Digite a 3ª nota";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(173, 104);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(222, 20);
            this.text3.TabIndex = 16;
            this.text3.TextChanged += new System.EventHandler(this.text3_TextChanged);
            // 
            // btAnalizar
            // 
            this.btAnalizar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnalizar.Location = new System.Drawing.Point(157, 255);
            this.btAnalizar.Name = "btAnalizar";
            this.btAnalizar.Size = new System.Drawing.Size(125, 40);
            this.btAnalizar.TabIndex = 18;
            this.btAnalizar.Text = "Analizar";
            this.btAnalizar.UseVisualStyleBackColor = true;
            this.btAnalizar.Click += new System.EventHandler(this.btAnalizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clique em Analizar para mostrar a situação do aluno";
            // 
            // resultAluno
            // 
            this.resultAluno.AutoSize = true;
            this.resultAluno.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultAluno.Location = new System.Drawing.Point(74, 307);
            this.resultAluno.Name = "resultAluno";
            this.resultAluno.Size = new System.Drawing.Size(137, 19);
            this.resultAluno.TabIndex = 20;
            this.resultAluno.Text = "Situação do aluno:";
            this.resultAluno.Click += new System.EventHandler(this.resultAluno_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 348);
            this.Controls.Add(this.resultAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAnalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.resultMedia);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultMedia;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sobrenome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button btAnalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultAluno;
    }
}