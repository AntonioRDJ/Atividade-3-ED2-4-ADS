using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgenda
{
    class Contatos
    {
        private readonly List<Contato> agenda;

        public List<Contato> Agenda
        {
            get { return agenda; }
        }

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            agenda.Add(c);
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            Contato contatoEncontrado = new Contato();
            agenda.ForEach(contato => {
                if(c.Email == contato.Email )
                {
                    contatoEncontrado = contato;
                }  
            });
            return contatoEncontrado;
        }

        public bool alterar(Contato c)
        {
            int posicao;
            posicao = agenda.IndexOf(c);
            if (posicao > -1)
            {
                agenda.RemoveAt(posicao);
                agenda.Insert(posicao, c);
            }
            return (posicao > -1);
        }

        public bool remover(Contato c)
        {
            bool podeRemover;
            podeRemover = (agenda.IndexOf(c) > -1);
            if (podeRemover)
                agenda.RemoveAt(agenda.IndexOf(c));
            return podeRemover;
        }

        public string listContatos()
        {
            string contatos = "";
            agenda.ForEach(contato => {
                contatos += contato.ToString() + "\n";
            });
            return contatos;
        }

    }
}
