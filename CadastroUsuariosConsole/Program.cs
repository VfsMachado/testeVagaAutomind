using System;
using System.Collections.Generic;

namespace CadastroUsuariosConsole
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Cadastro de Usuários ===");
                Console.WriteLine("1. Cadastrar novo usuário");
                Console.WriteLine("2. Listar todos os usuários");
                Console.WriteLine("3. Buscar usuário por nome");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarUsuario();
                        break;
                    case "2":
                        ListarUsuarios();
                        break;
                    case "3":
                        BuscarUsuario();
                        break;
                    case "4":
                        executando = false;
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void CadastrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("--- Cadastro de Novo Usuário ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Idade: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Idade inválida. Digite novamente: ");
            }

            usuarios.Add(new Usuario(nome, email, idade));
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
        }

        static void ListarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de Usuários Cadastrados ---");

            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
                }
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu.");
            Console.ReadLine();
        }

        static void BuscarUsuario()
        {
            Console.Clear();
            Console.WriteLine("--- Buscar Usuário ---");
            Console.Write("Digite o nome: ");
            string nomeBusca = Console.ReadLine();

            Usuario encontrado = usuarios.Find(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                Console.WriteLine("\nUsuário encontrado:");
                Console.WriteLine($"Nome: {encontrado.Nome}");
                Console.WriteLine($"Email: {encontrado.Email}");
                Console.WriteLine($"Idade: {encontrado.Idade}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
