using System;
using System.Collections.Generic;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;

namespace Dominio.Servicos
{
    public class ServicoPadrao<TEntity> : IServicoPadrao<TEntity>, IDisposable where TEntity : class
    {
        private readonly IRepositorioPadrao<TEntity> _repositorio;

        public ServicoPadrao(IRepositorioPadrao<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adiciona(TEntity obj)
        {
            _repositorio.Adiciona(obj);
        }

        public TEntity BuscaPorId(int id)
        {
            return _repositorio.BuscaPorId(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return _repositorio.BuscaTodos();
        }

        public void Atualiza(TEntity obj)
        {
            _repositorio.Atualiza(obj);
        }

        public void Exclui(TEntity obj)
        {
            _repositorio.Exclui(obj);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
