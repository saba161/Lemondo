using CRUD_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BAL.Interface
{
    public interface IStatement
    {
        Task<IEnumerable<StatementEntity>> GetStatements();
        Task DeleteStatement(int id);
        Task PutStatement(StatementEntity statement);
        Task<StatementEntity> GetStatementById(int id);
    }
}
