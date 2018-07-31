using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Dados.Context;
using Dominio.Interfaces.Repositorio;

namespace Dados.Repositorios
{
    public class RepositorioPadrao<TEntity> : IDisposable, IRepositorioPadrao<TEntity> where TEntity : class
    {
        protected DataContext Db = new DataContext();
        public void Adiciona(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            SaveChanges();
        }

        public TEntity BuscaPorId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Atualiza(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            SaveChanges();
        }

        public void Exclui(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        void IRepositorioPadrao<TEntity>.Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        void IDisposable.Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}