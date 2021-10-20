using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgenda
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public Contato() { }

        public Contato(string email)
        {
            this.email = email;
        }

        public int getIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - DtNasc.Ano;
        }

        public override string ToString()
        {
            return $"Email: {Email} - Nome: {Nome} - Telefone: {Telefone} - Data de Nascimento: {DtNasc.ToString()}";
        }
    }
}
