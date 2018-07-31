using System;
using System.Collections.Generic;
using Aplicacao.Interfaces;
using Dominio.Interfaces.Servico;

namespace Aplicacao.Servicos
{
    public class AppServicoPadrao<TEntity> : IDisposable, IAppServicoPadrao<TEntity> where TEntity : class
    {
        private readonly IServicoPadrao<TEntity> _servicoPadrao;

        public AppServicoPadrao(IServicoPadrao<TEntity> servicoPadrao)
        {
            _servicoPadrao = servicoPadrao;
        }

        public void Dispose()
        {
            _servicoPadrao.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Adiciona(TEntity obj)
        {
            _servicoPadrao.Adiciona(obj);
        }

        public TEntity BuscaPorId(int id)
        {
            return _servicoPadrao.BuscaPorId(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return _servicoPadrao.BuscaTodos();
        }

        public void Atualiza(TEntity obj)
        {
            _servicoPadrao.Atualiza(obj);
        }

        public void Exclui(TEntity obj)
        {
            _servicoPadrao.Exclui(obj);
        }
    }
}
