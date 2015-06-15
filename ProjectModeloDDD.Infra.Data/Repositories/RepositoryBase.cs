using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectModeloDDD.Domain.Interfaces.Repositories;
using ProjectModeloDDD.Infra.Data.Contexto;

namespace ProjectModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase <TEntiry> : IDisposable, IRepositoryBase<TEntiry> where TEntiry : class
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Add(TEntiry obj)
        {
            Db.Set<TEntiry>().Add(obj);
            Db.SaveChanges();
        }

        public TEntiry GetById(int id)
        {
            return Db.Set<TEntiry>().Find(id);
        }

        public IEnumerable<TEntiry> GetAll()
        {
            return Db.Set<TEntiry>().ToList();
        }

        public void Update(TEntiry obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntiry obj)
        {
            Db.Set<TEntiry>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
