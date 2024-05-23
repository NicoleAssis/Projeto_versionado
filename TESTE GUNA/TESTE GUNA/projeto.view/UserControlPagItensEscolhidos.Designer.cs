namespace TESTE_GUNA.projeto.view
{
    partial class UserControlPagItensEscolhidos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // labelDescricao
            // 
            this.labelDescricao.BackColor = System.Drawing.Color.Transparent;
            this.labelDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.labelDescricao.Location = new System.Drawing.Point(0, 36);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(175, 37);
            this.labelDescricao.TabIndex = 44;
            this.labelDescricao.Text = "10 Comprimidos de 5mg";
            // 
            // labelNome
            // 
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.labelNome.Location = new System.Drawing.Point(-1, 5);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(233, 33);
            this.labelNome.TabIndex = 43;
            this.labelNome.Text = "Cloridrato de Naratriptana";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.labelSubtotal.Location = new System.Drawing.Point(172, 33);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(110, 20);
            this.labelSubtotal.TabIndex = 45;
            this.labelSubtotal.Text = "Subtotal: 35,00";
            this.labelSubtotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.labelQtd.Location = new System.Drawing.Point(228, 5);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(48, 20);
            this.labelQtd.TabIndex = 46;
            this.labelQtd.Text = "Qtd: 1";
            this.labelQtd.Click += new System.EventHandler(this.labelQtd_Click);
            // 
            // UserControlPagItensEscolhidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "UserControlPagItensEscolhidos";
            this.Size = new System.Drawing.Size(287, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelQtd;
    }
}
