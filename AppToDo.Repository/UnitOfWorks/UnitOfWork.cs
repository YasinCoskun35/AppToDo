using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppToDo.Core.UnitOfWorks;
using AppToDo.Repository.DBContext;

namespace AppToDo.Repository.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppToDoDbContext _context;

        public UnitOfWork(AppToDoDbContext context)
        {
            _context=context;
        }
        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
