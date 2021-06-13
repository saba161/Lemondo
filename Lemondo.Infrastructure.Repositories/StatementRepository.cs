using Lemondo.Core.Models.Statements;
using Lemondo.Core.Repositories;
using Lemondo.Infrastructure.Mappers;
using Lemondo.Infrastructure.Store;
using Lemondo.Infrastructure.Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondo.Infrastructure.Repositories
{
    public class StatementRepository : ICrud<Statement>
    {
        private readonly ApplicationDbContext _dbContext;
        public StatementRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task Create(Statement _object)
        {
            try
            {
                await _dbContext.AddAsync<StatementEntity>(_object.AsEntity());
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            var statement = await _dbContext.Statements
                 .Where(x => x.Id == id)
                 .FirstOrDefaultAsync();

            _dbContext.Remove(statement);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<StatementEntity>> GetAll()
        {
            return await _dbContext.Statements.ToListAsync();
        }

        public async Task<Statement> GetById(int Id)
        {
            var statement = await _dbContext.Statements
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync();

            return statement.AsDomain();
        }

        public async Task Update(Statement _object)
        {
            var statement = await _dbContext.Statements.FindAsync(_object.Id);

            statement.Name = _object.Name;
            statement.Description = _object.Description;
            statement.Photo = _object.Photo;

            await _dbContext.SaveChangesAsync();
        }

        Task<IEnumerable<Statement>> ICrud<Statement>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}