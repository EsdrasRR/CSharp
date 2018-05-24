using System.Collections.Generic;

namespace Controllers.Base
{
    interface IBaseController<X> where X : class
    {
        void Adicionar(X entity);
        IList<X> ListarTodos();
        IList<X> ListarPorNome(string nome);
        X BuscarPorID(int id);
        void Atualizar(X entity);
        void Excluir(int id);

    }
}
