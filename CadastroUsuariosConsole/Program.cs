using System;
using System.Collections.Generic;
using System.Linq;
using CadastroUsuariosConsole;

namespace CadastroUsuariosConsole { 
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de usuários cadastrados
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario("Victor Fernando", "Vfsmachado27@gmail.com", 21),
                new Usuario("Maria", "maria@example.com", 30),
                new Usuario("Carlos", "carlos@example.com", 28)
            };

            // Listagem de todos os usuários cadastrados (apenas os nomes)
            Console.WriteLine("Lista de usuários cadastrados:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Nome);
            }
            
            
            // Solicita ao usuário um nome para buscar
            Console.Write("Digite o nome do usuário para buscar: ");
            string nomeBusca = Console.ReadLine();

            // Busca do usuário na lista
            Usuario usuarioEncontrado = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    usuarioEncontrado = usuario;
                    break; // Sai do loop quando encontrar o usuário
                }
            }

            // Resultado da busca
            if (usuarioEncontrado != null)
            {
                Console.WriteLine("\nUsuário encontrado:");
                Console.WriteLine($"Nome: {usuarioEncontrado.Nome}");
                Console.WriteLine($"Email: {usuarioEncontrado.Email}");
                Console.WriteLine($"Idade: {usuarioEncontrado.Idade}");
            }
            else
            {
                Console.WriteLine("\nUsuário não encontrado.");
            }
        }
    }
}
