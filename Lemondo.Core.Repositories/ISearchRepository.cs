using Lemondo.Core.Models.Statements;
using System.Threading.Tasks;

namespace Lemondo.Core.Repositories
{
    public interface ISearchRepository
    {
        Task<Statement> SearchByName(string name);
    }
}