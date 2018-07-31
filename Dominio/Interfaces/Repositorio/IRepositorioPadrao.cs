using System.Collections.Generic;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioPadrao<TEntity> where TEntity : class
    {
        void Adiciona(TEntity obj);
        TEntity BuscaPorId(int id);
        IEnumerable<TEntity> BuscaTodos();
        void Atualiza(TEntity obj);
        void Exclui(TEntity obj);
        void Dispose();
    }
}