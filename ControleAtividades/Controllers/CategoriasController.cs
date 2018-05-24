
using Modelos;
using System.Collections.Generic;
using Controllers.Base;

namespace Controllers
{
    public class CategoriasController
    {
        //Simulando Tabela
        private List<Categoria> ListaCategorias { get; set; }

        //ADD
        public void Adicionar(Categoria categoria)
        {
            ListaCategorias.Add(categoria);
        }
        //Listar
        public List<Categoria> ListarTodos()
        {
            return ListaCategorias;
        }
        //ListarPorNome
        public List<Categoria> ListarPorNome(string nome)
        {

        }

        //BuscarPorID
        public Categoria BuscarPorID(int id)
        {
            foreach (Categoria c in ListaCategorias)
            {
                if (c.CategoriaID == id)
                {
                    return c;
                }
            }
            return null;
        }

        //Atualizar
        public void Atualizar(int id, Categoria CategoriaAtualizado)
        {
            Categoria categoriaAntiga = BuscarPorID(id);

            if (categoriaAntiga != null)
            {
                categoriaAntiga.Nome = CategoriaAtualizado.Nome;
                categoriaAntiga.Ativo = CategoriaAtualizado.Ativo;
            }
        }

        //Excluir
        public void Excluir(int id)
        {
            Categoria categoria = BuscarPorID(id);

            if (categoria != null)
            {
                ListaCategorias.Remove(categoria);
            }

        }

    }
}

