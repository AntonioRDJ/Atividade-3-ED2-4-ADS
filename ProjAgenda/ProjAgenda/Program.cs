using System;

namespace ProjAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int opSelecionada;

            Contatos contatos = new Contatos();

            while (!sair)
            {

                Console.WriteLine("\n0. Sair \n1.Adicionar contato \n2.Pesquisar contato \n3.Alterar contato \n4.Remover contato \n5.Listar contatos");
                opSelecionada = int.Parse(Console.ReadLine());


                switch (opSelecionada)
                {
                    case 0:
                        sair = true;
                        break;
                    case 1:
                        addContato(contatos);
                        break;
                    case 2:
                        pesqContato(contatos);
                        break;
                    case 3:
                        altContato(contatos);
                        break;
                    case 4:
                        remContato(contatos);
                        break;
                    case 5:
                        listContatos(contatos);
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }
            }

            void addContato(Contatos contatos)
            {
                Console.WriteLine("Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Telefone:");
                string telefone = Console.ReadLine();

                Console.WriteLine("Data de nascimento:");

                Console.WriteLine("Dia:");
                int dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Mês:");
                int mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ano:");
                int ano = int.Parse(Console.ReadLine());

                Contato novoContato = new Contato(email, nome, telefone, new Data(dia,mes,ano));
                contatos.adicionar(novoContato);
            }

            void pesqContato(Contatos contatos)
            {
                Console.WriteLine("Digite o Email do contato:");
                string email = Console.ReadLine();

                Contato pesqContato = contatos.pesquisar(new Contato(email));
                Console.WriteLine($"Contato: {pesqContato.ToString()}");
            }

            void altContato(Contatos contatos)
            {
                Console.WriteLine("Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Telefone:");
                string telefone = Console.ReadLine();

                Console.WriteLine("Data de nascimento:");

                Console.WriteLine("Dia:");
                int dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Mês:");
                int mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ano:");
                int ano = int.Parse(Console.ReadLine());

                Contato altContato = new Contato(email, nome, telefone, new Data(dia, mes, ano));

                Console.WriteLine(contatos.alterar(altContato) ? "Contato alterado." : "Contato não alterado");
            }

            void remContato(Contatos contatos)
            {
                Console.WriteLine("Digite o Email do contato:");
                string email = Console.ReadLine();

                Contato pesqContato = contatos.pesquisar(new Contato(email));

                contatos.remover(pesqContato);
                Console.WriteLine(contatos.remover(pesqContato) ? "Contato removido" : "Contato não removido");
            }

            void listContatos(Contatos contatos)
            {
                Console.WriteLine($"Contatos: \n{contatos.listContatos()}");
            }
        }
    }
}
