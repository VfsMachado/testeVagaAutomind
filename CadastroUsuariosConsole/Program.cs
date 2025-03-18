using System;
using System.Collections.Generic;
using System.Linq;
using CadastroUsuariosConsole;

namespace CadastroUsuariosConsole { 
    class Program
    {
        static void Main(string[] args)
        {
            // usuários cadastrados
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario("Victor Fernando", "Vfsmachado27@gmail.com", 21),
                new Usuario("Maria", "maria@example.com", 30),
                new Usuario("Carlos", "carlos@example.com", 28)
            };

            // funcionalidade que lista todos os usuários
            Console.WriteLine("Lista de usuários cadastrados:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Nome);
            }
            

            // busca de usuarios
            Console.Write("Digite o nome do usuário para buscar: ");
            string nomeBusca = Console.ReadLine();

            // resultado da busca na lista
            Usuario usuarioEncontrado = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    usuarioEncontrado = usuario;
                    break; 
                    
                    // interrompe o loop qnd o nome for achado
                }
            }

            // resultado da busca
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
