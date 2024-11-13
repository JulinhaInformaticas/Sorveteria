namespace Sorveteria
{
    partial class Tela_cadastro
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
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txb_cod = new System.Windows.Forms.TextBox();
            this.txb_desc = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.cmb_med = new System.Windows.Forms.ComboBox();
            this.lbl_med = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_imagem = new System.Windows.Forms.Label();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txb_estoque = new System.Windows.Forms.TextBox();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cadastrarprod = new System.Windows.Forms.Button();
            this.ltv_prod = new System.Windows.Forms.ListView();
            this.clm_cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_med = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(43, 37);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(93, 13);
            this.lbl_cod.TabIndex = 0;
            this.lbl_cod.Text = "código do produto";
            // 
            // txb_cod
            // 
            this.txb_cod.Location = new System.Drawing.Point(46, 53);
            this.txb_cod.Name = "txb_cod";
            this.txb_cod.Size = new System.Drawing.Size(100, 20);
            this.txb_cod.TabIndex = 1;
            // 
            // txb_desc
            // 
            this.txb_desc.Location = new System.Drawing.Point(46, 145);
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.Size = new System.Drawing.Size(100, 20);
            this.txb_desc.TabIndex = 3;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(43, 129);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(53, 13);
            this.lbl_desc.TabIndex = 2;
            this.lbl_desc.Text = "descrição";
            // 
            // cmb_med
            // 
            this.cmb_med.FormattingEnabled = true;
            this.cmb_med.Items.AddRange(new object[] {
            "Kg",
            "Un",
            "G"});
            this.cmb_med.Location = new System.Drawing.Point(46, 199);
            this.cmb_med.Name = "cmb_med";
            this.cmb_med.Size = new System.Drawing.Size(121, 21);
            this.cmb_med.TabIndex = 4;
            // 
            // lbl_med
            // 
            this.lbl_med.AutoSize = true;
            this.lbl_med.Location = new System.Drawing.Point(43, 183);
            this.lbl_med.Name = "lbl_med";
            this.lbl_med.Size = new System.Drawing.Size(97, 13);
            this.lbl_med.TabIndex = 5;
            this.lbl_med.Text = "unidade de medida";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(46, 101);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(100, 20);
            this.txb_nome.TabIndex = 7;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(43, 85);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(87, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "nome do produto";
            // 
            // lbl_imagem
            // 
            this.lbl_imagem.AutoSize = true;
            this.lbl_imagem.Location = new System.Drawing.Point(43, 241);
            this.lbl_imagem.Name = "lbl_imagem";
            this.lbl_imagem.Size = new System.Drawing.Size(97, 13);
            this.lbl_imagem.TabIndex = 9;
            this.lbl_imagem.Text = "imagem do produto";
            this.lbl_imagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(290, 53);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(100, 20);
            this.txb_preco.TabIndex = 11;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(287, 37);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(37, 13);
            this.lbl_preco.TabIndex = 10;
            this.lbl_preco.Text = "preço ";
            // 
            // txb_estoque
            // 
            this.txb_estoque.Location = new System.Drawing.Point(290, 101);
            this.txb_estoque.Name = "txb_estoque";
            this.txb_estoque.Size = new System.Drawing.Size(100, 20);
            this.txb_estoque.TabIndex = 13;
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Location = new System.Drawing.Point(287, 85);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(45, 13);
            this.lbl_estoque.TabIndex = 12;
            this.lbl_estoque.Text = "estoque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 143);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_cadastrarprod
            // 
            this.btn_cadastrarprod.Location = new System.Drawing.Point(608, 387);
            this.btn_cadastrarprod.Name = "btn_cadastrarprod";
            this.btn_cadastrarprod.Size = new System.Drawing.Size(143, 34);
            this.btn_cadastrarprod.TabIndex = 14;
            this.btn_cadastrarprod.Text = "CADASTRAR";
            this.btn_cadastrarprod.UseVisualStyleBackColor = true;
            this.btn_cadastrarprod.Click += new System.EventHandler(this.btn_cadastrarprod_Click);
            // 
            // ltv_prod
            // 
            this.ltv_prod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_cod,
            this.clm_nome,
            this.clm_preco,
            this.clm_desc,
            this.clm_med});
            this.ltv_prod.HideSelection = false;
            this.ltv_prod.Location = new System.Drawing.Point(267, 173);
            this.ltv_prod.Name = "ltv_prod";
            this.ltv_prod.Size = new System.Drawing.Size(312, 237);
            this.ltv_prod.TabIndex = 15;
            this.ltv_prod.UseCompatibleStateImageBehavior = false;
            this.ltv_prod.View = System.Windows.Forms.View.Details;
            // 
            // clm_cod
            // 
            this.clm_cod.Text = "cod";
            // 
            // clm_nome
            // 
            this.clm_nome.Text = "nome";
            // 
            // clm_preco
            // 
            this.clm_preco.Text = "preço";
            // 
            // clm_desc
            // 
            this.clm_desc.Text = "descrição";
            // 
            // clm_med
            // 
            this.clm_med.Text = "un. medida";
            this.clm_med.Width = 70;
            // 
            // Tela_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltv_prod);
            this.Controls.Add(this.btn_cadastrarprod);
            this.Controls.Add(this.txb_estoque);
            this.Controls.Add(this.lbl_estoque);
            this.Controls.Add(this.txb_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_imagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_med);
            this.Controls.Add(this.cmb_med);
            this.Controls.Add(this.txb_desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txb_cod);
            this.Controls.Add(this.lbl_cod);
            this.Name = "Tela_cadastro";
            this.Text = "Tela_cadastro";
            this.Load += new System.EventHandler(this.Tela_cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txb_cod;
        private System.Windows.Forms.TextBox txb_desc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.ComboBox cmb_med;
        private System.Windows.Forms.Label lbl_med;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_imagem;
        private System.Windows.Forms.TextBox txb_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txb_estoque;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.Button btn_cadastrarprod;
        private System.Windows.Forms.ListView ltv_prod;
        private System.Windows.Forms.ColumnHeader clm_cod;
        private System.Windows.Forms.ColumnHeader clm_nome;
        private System.Windows.Forms.ColumnHeader clm_preco;
        private System.Windows.Forms.ColumnHeader clm_desc;
        private System.Windows.Forms.ColumnHeader clm_med;
    }
}