using Modelos;
using System.Collections.Generic;
using Controllers.Base;

namespace Controllers
{
    public class AtividadesController
    {
        //Simulando Tabela
        private List<Atividade> ListaAtividades { get; set; }

        //ADD
        public void Adicionar(Atividade atividade)
        {
            ListaAtividades.Add(atividade);
        }
        //Listar
        public List<Atividade> ListarTodos()
        {
            return ListaAtividades;
        }
        //ListarPorNome
        public List<Atividade> ListarPorNome(string nome)
        {

        }

        //BuscarPorID
        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in ListaAtividades)
            {
                if (a.CategoriaID == id)
                {
                    return a;
                }
            }
            return null;
        }

        //Atualizar
        public void Atualizar(int id, Atividade AtividadeAtualizada)
        {
            Atividade AtividadeAntiga = BuscarPorID(id);

            if (AtividadeAntiga != null)
            {
                AtividadeAntiga.Nome = AtividadeAtualizada.Nome;
                AtividadeAntiga.Ativo = AtividadeAtualizada.Ativo;
            }
        }

        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);

            if (atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }

        }
    }
}
