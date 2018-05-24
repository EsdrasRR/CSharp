
using Modelos;
using System.Collections.Generic;
using Controllers.Base;

namespace Controllers
{
    public class UsuariosController
    {
        //Simulando Tabela
        private List<Usuario> ListaUsuarios { get; set; }

        //ADD
        public void Adicionar(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }
        //Listar
        public List<Usuario> ListarTodos()
        {   
            return ListaUsuarios;
        }
        //ListarPorNome
        public List<Usuario> ListarPorNome(string nome)
        {

        }

        //BuscarPorID
        public Usuario BuscarPorID(int id)
        {
            foreach (Usuario u in ListaUsuarios)
            {
                if(u.UsuarioID == id)
                {
                    return u;
                }
            }
            return null;
        }

        //Atualizar
        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            Usuario usuarioAntigo = BuscarPorID(id);

            if (usuarioAntigo != null)
            {
                usuarioAntigo.Nome = UsuarioAtualizado.Nome;
                usuarioAntigo.Ativo = UsuarioAtualizado.Ativo;
            }
        }

        //Excluir
        public void Excluir (int id)
        {
            Usuario usuario = BuscarPorID(id);

            if(usuario != null)
            {
                ListaUsuarios.Remove(usuario);
            }
                
        }

    }
}
