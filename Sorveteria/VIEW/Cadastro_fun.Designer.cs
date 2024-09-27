namespace Sorveteria
{
    partial class Cadastro_fun
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
            this.lbl_codfun = new System.Windows.Forms.Label();
            this.txb_codfun = new System.Windows.Forms.TextBox();
            this.txb_nomefun = new System.Windows.Forms.TextBox();
            this.lbl_nomefun = new System.Windows.Forms.Label();
            this.txb_depto = new System.Windows.Forms.TextBox();
            this.lbl_depto = new System.Windows.Forms.Label();
            this.txb_funcao = new System.Windows.Forms.TextBox();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_codfun
            // 
            this.lbl_codfun.AutoSize = true;
            this.lbl_codfun.Location = new System.Drawing.Point(45, 32);
            this.lbl_codfun.Name = "lbl_codfun";
            this.lbl_codfun.Size = new System.Drawing.Size(109, 13);
            this.lbl_codfun.TabIndex = 0;
            this.lbl_codfun.Text = "código do funcionário";
            // 
            // txb_codfun
            // 
            this.txb_codfun.Location = new System.Drawing.Point(48, 58);
            this.txb_codfun.Name = "txb_codfun";
            this.txb_codfun.Size = new System.Drawing.Size(100, 20);
            this.txb_codfun.TabIndex = 1;
            // 
            // txb_nomefun
            // 
            this.txb_nomefun.Location = new System.Drawing.Point(48, 129);
            this.txb_nomefun.Name = "txb_nomefun";
            this.txb_nomefun.Size = new System.Drawing.Size(100, 20);
            this.txb_nomefun.TabIndex = 3;
            // 
            // lbl_nomefun
            // 
            this.lbl_nomefun.AutoSize = true;
            this.lbl_nomefun.Location = new System.Drawing.Point(45, 103);
            this.lbl_nomefun.Name = "lbl_nomefun";
            this.lbl_nomefun.Size = new System.Drawing.Size(103, 13);
            this.lbl_nomefun.TabIndex = 2;
            this.lbl_nomefun.Text = "nome do funcionário";
            // 
            // txb_depto
            // 
            this.txb_depto.Location = new System.Drawing.Point(48, 205);
            this.txb_depto.Name = "txb_depto";
            this.txb_depto.Size = new System.Drawing.Size(100, 20);
            this.txb_depto.TabIndex = 5;
            // 
            // lbl_depto
            // 
            this.lbl_depto.AutoSize = true;
            this.lbl_depto.Location = new System.Drawing.Point(45, 179);
            this.lbl_depto.Name = "lbl_depto";
            this.lbl_depto.Size = new System.Drawing.Size(72, 13);
            this.lbl_depto.TabIndex = 4;
            this.lbl_depto.Text = "departamento";
            // 
            // txb_funcao
            // 
            this.txb_funcao.Location = new System.Drawing.Point(48, 286);
            this.txb_funcao.Name = "txb_funcao";
            this.txb_funcao.Size = new System.Drawing.Size(100, 20);
            this.txb_funcao.TabIndex = 7;
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Location = new System.Drawing.Point(45, 260);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(40, 13);
            this.lbl_funcao.TabIndex = 6;
            this.lbl_funcao.Text = "função";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(237, 32);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(37, 13);
            this.lbl_salario.TabIndex = 8;
            this.lbl_salario.Text = "salário";
            // 
            // Cadastro_fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.txb_funcao);
            this.Controls.Add(this.lbl_funcao);
            this.Controls.Add(this.txb_depto);
            this.Controls.Add(this.lbl_depto);
            this.Controls.Add(this.txb_nomefun);
            this.Controls.Add(this.lbl_nomefun);
            this.Controls.Add(this.txb_codfun);
            this.Controls.Add(this.lbl_codfun);
            this.Name = "Cadastro_fun";
            this.Text = "Cadastro_fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codfun;
        private System.Windows.Forms.TextBox txb_codfun;
        private System.Windows.Forms.TextBox txb_nomefun;
        private System.Windows.Forms.Label lbl_nomefun;
        private System.Windows.Forms.TextBox txb_depto;
        private System.Windows.Forms.Label lbl_depto;
        private System.Windows.Forms.TextBox txb_funcao;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_salario;
    }
}