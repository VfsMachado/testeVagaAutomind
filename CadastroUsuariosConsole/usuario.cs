namespace CadastroUsuariosConsole {
    // classe do usuario 
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        // Construtor para organizar melhor os dados
        public Usuario(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
  }