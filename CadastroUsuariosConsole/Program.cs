using System;
using System.Collections.Generic;
using System.Linq;



    class Program
    {
        static void Main(string[] args)
        {
            // Lista de usuários cadastrados
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario("João", "joao@example.com", 25),
                new Usuario("Maria", "maria@example.com", 30),
                new Usuario("Carlos", "carlos@example.com", 28)
            };

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
