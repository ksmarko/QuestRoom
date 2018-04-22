using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private GenericRepository<Quest> questRepository;
        private GenericRepository<Reserv> reservRepository;
           
        public EFUnitOfWork(string connectionString)
        {
            db = new DataContext(connectionString);
        }

        public IRepository<Quest> Quests
        {
            get
            {
                if (questRepository == null)
                    questRepository = new GenericRepository<Quest>(db);
                return questRepository;
            }
        }

        public IRepository<Reserv> Reserves
        {
            get
            {
                if (reservRepository == null)
                    reservRepository = new GenericRepository<Reserv>(db);
                return reservRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
