namespace Aula_10_05_18_POO
{
    class Pessoa
    {
        private string nome;
        private string cpf;

        public string Cpf { get; set; }
        public string Nome { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }
}
