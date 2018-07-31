using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAppServicoPadrao<TEntity> where TEntity : class
    {
        void Adiciona(TEntity obj);
        TEntity BuscaPorId(int id);
        IEnumerable<TEntity> BuscaTodos();
        void Atualiza(TEntity obj);
        void Exclui(TEntity obj);
    }
}
