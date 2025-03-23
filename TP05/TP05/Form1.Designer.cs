namespace TP05
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
            this.lbWhatsapp = new System.Windows.Forms.Label();
            this.txWhatsapp = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.dtGridContato = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContato)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWhatsapp
            // 
            this.lbWhatsapp.AutoSize = true;
            this.lbWhatsapp.Location = new System.Drawing.Point(12, 143);
            this.lbWhatsapp.Name = "lbWhatsapp";
            this.lbWhatsapp.Size = new System.Drawing.Size(57, 13);
            this.lbWhatsapp.TabIndex = 0;
            this.lbWhatsapp.Text = "WhatsApp";
            // 
            // txWhatsapp
            // 
            this.txWhatsapp.Location = new System.Drawing.Point(15, 160);
            this.txWhatsapp.Name = "txWhatsapp";
            this.txWhatsapp.Size = new System.Drawing.Size(100, 20);
            this.txWhatsapp.TabIndex = 1;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(15, 106);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 89);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(15, 52);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(100, 20);
            this.txNome.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // dtGridContato
            // 
            this.dtGridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridContato.Location = new System.Drawing.Point(15, 240);
            this.dtGridContato.Name = "dtGridContato";
            this.dtGridContato.Size = new System.Drawing.Size(357, 207);
            this.dtGridContato.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(194, 48);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(73, 63);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar Contato";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dtGridContato);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txWhatsapp);
            this.Controls.Add(this.lbWhatsapp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhatsapp;
        private System.Windows.Forms.TextBox txWhatsapp;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridView dtGridContato;
        private System.Windows.Forms.Button btSalvar;
    }
}

