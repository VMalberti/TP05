using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    internal class Contato
    {
        public string Nome { get; set; }    
        public string Email { get; set; }
        public int Whatsapp { get; set; }

    }
    internal class ContatoModel
    {
        private static List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public List<Contato> ListarContatos()
        {
            return contatos;
        }
    }
    internal class ContatoController
    {
        private ContatoModel model = new ContatoModel();

        public string SalvarContatos (string nome, string email, string whatsapp)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
                return "Nome e Contato são obrigatórios.";

            if (!int.TryParse(whatsapp, out int Whatsapp))
                return "WhatsApp inválido.";

            Contato contato = new Contato
            {
                Nome = nome,
                Email = email,
                Whatsapp = Whatsapp
            };

            model.AdicionarContato(contato);
            return "Contato salvo com sucesso!";
        }

        public List<Contato> ObterContatos()
        {
            return model.ListarContatos();
        }
    }
}


