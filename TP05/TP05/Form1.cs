using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP05
{
    public partial class Form1 : Form
    {
        private ContatoController controller = new ContatoController();
        public Form1()
        {
            InitializeComponent();
        }
        private void AtualizarContato()
        {
            List<Contato> contatos = controller.ObterContatos();
            dtGridContato.DataSource = null;
            dtGridContato.DataSource = contatos;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string email = txEmail.Text;
            string whatsapp = txWhatsapp.Text;

            string mensagem = controller.SalvarContatos(nome, email, whatsapp);
            MessageBox.Show(mensagem);

            AtualizarContato();
        }
    }
}
