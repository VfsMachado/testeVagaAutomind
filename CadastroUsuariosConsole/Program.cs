using System;
using System.Collections.Generic;
using System.Linq;
using CadastroUsuariosConsole;

namespace CadastroUsuariosConsole
{  
// classe do usuario 
public class Usuario {
    public string NOME { get; set; }
    public string EMAIL { get; set; }
    public int IDADE { get; set; }

    //construtor
     public Usuario(string nome, string email, int idade) {
        NOME = nome;
        EMAIL = email;
        IDADE = idade;
    }
}

}


class Program {
//  armazenar usuarios 
    static void Main(string[] args)

    //lista de usuarios
    List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("João", "joao@example.com", 25),
            new Usuario("Maria", "maria@example.com", 30),
            new Usuario("Carlos", "carlos@example.com", 28)
        };

        // solicitar busca do usuario
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
