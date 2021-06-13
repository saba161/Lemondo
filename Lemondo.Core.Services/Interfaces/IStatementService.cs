using Lemondo.Core.Models.Statements;
using Lemondo.Infrastructure.Store.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lemondo.Core.Services.Interfaces
{
    public interface IStatementService
    {
        Task<IEnumerable<Statement>> GetStatements();
        Task DeleteStatement(int id);
        Task PutStatement(Statement statement);
        Task<Statement> GetStatementById(int id);
    }
}
