namespace Sorveteria
{
    partial class Login
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
            this.txb_User = new System.Windows.Forms.TextBox();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_User
            // 
            this.txb_User.Location = new System.Drawing.Point(113, 228);
            this.txb_User.Name = "txb_User";
            this.txb_User.Size = new System.Drawing.Size(216, 20);
            this.txb_User.TabIndex = 0;
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(113, 298);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(216, 20);
            this.txb_senha.TabIndex = 1;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(121, 203);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(47, 13);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "usuário :";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(121, 269);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(42, 13);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "senha :";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(548, 365);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(99, 23);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "CADASTRAR";
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(439, 269);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "nome :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(439, 203);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "email :";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(431, 298);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(216, 20);
            this.txb_nome.TabIndex = 7;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(431, 228);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(216, 20);
            this.txb_email.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_User);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_User;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_email;
    }
}