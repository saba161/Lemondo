using Lemondo.Core.Models.Statements;
using Lemondo.Core.Repositories;
using Lemondo.Infrastructure.Mappers;
using Lemondo.Infrastructure.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondo.Infrastructure.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SearchRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Statement> SearchByName(string name)
        {
            var statement = await _dbContext.Statements.Where(x => x.Name == name)
                .FirstOrDefaultAsync();

            return statement.AsDomain();
        }
    }
}