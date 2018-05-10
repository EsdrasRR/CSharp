using System;

namespace Aula_10_05_18_POO
{
    class Cliente : Pessoa
    {

        public DateTime DataNasc { get; set; }
        public Cliente()
        {
        }
        public Cliente(string nome, string cpf) : base(nome, cpf)
        {
                
        }
    }
}
