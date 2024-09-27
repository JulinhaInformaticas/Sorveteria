using System;

namespace Sorveteria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESSOASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRight = new System.Windows.Forms.Button();
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.cOMPRARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESSOASToolStripMenuItem,
            this.pRODUTOSToolStripMenuItem,
            this.fUNCIONÁRIOSToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrosToolStripMenuItem.Text = "CADASTROS";
            // 
            // pESSOASToolStripMenuItem
            // 
            this.pESSOASToolStripMenuItem.Name = "pESSOASToolStripMenuItem";
            this.pESSOASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pESSOASToolStripMenuItem.Text = "PESSOAS";
            this.pESSOASToolStripMenuItem.Click += new System.EventHandler(this.pESSOASToolStripMenuItem_Click);
            // 
            // pRODUTOSToolStripMenuItem
            // 
            this.pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            this.pRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOSToolStripMenuItem_Click);
            // 
            // fUNCIONÁRIOSToolStripMenuItem
            // 
            this.fUNCIONÁRIOSToolStripMenuItem.Name = "fUNCIONÁRIOSToolStripMenuItem";
            this.fUNCIONÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fUNCIONÁRIOSToolStripMenuItem.Text = "FUNCIONÁRIOS";
            this.fUNCIONÁRIOSToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONÁRIOSToolStripMenuItem_Click);
            // 
            // cOMPRARToolStripMenuItem
            // 
            this.cOMPRARToolStripMenuItem.Name = "cOMPRARToolStripMenuItem";
            this.cOMPRARToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cOMPRARToolStripMenuItem.Text = "COMPRAR";
            this.cOMPRARToolStripMenuItem.Click += new System.EventHandler(this.cOMPRARToolStripMenuItem_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::Sorveteria.Properties.Resources.right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.ForeColor = System.Drawing.Color.MistyRose;
            this.btnRight.Location = new System.Drawing.Point(681, 289);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 32);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pcbMenu
            // 
            this.pcbMenu.BackColor = System.Drawing.Color.Linen;
            this.pcbMenu.Image = global::Sorveteria.Properties.Resources.sorvetes;
            this.pcbMenu.Location = new System.Drawing.Point(195, 27);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(498, 506);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 0;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.Tag = "p3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(918, 534);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pcbMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "sorveteria do Julio";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRight;
        private readonly EventHandler Form1_Load;
        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESSOASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem;
    }
}

