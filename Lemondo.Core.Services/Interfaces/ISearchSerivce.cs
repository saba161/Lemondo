using Lemondo.Core.Models.Statements;
using System.Threading.Tasks;

namespace Lemondo.Core.Services.Interfaces
{
    public interface ISearchSerivce
    {
        Task<Statement> SearchByName(string name);
    }
}
