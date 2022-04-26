using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivace.Core.UnitOfWorks;

namespace Vivace.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VivaceDbContext _dbContext;

        public UnitOfWork(VivaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
