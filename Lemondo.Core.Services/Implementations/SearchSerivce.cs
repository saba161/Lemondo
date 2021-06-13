using Lemondo.Core.Models.Statements;
using Lemondo.Core.Repositories;
using Lemondo.Core.Services.Interfaces;
using System.Threading.Tasks;

namespace Lemondo.Core.Services.Implementations
{
    public class SearchSerivce : ISearchSerivce
    {
        private readonly ISearchRepository _searchSerivce;
        public SearchSerivce(ISearchRepository searchSerivce)
        {
            _searchSerivce = searchSerivce;
        }
        public async Task<Statement> SearchByName(string name)
        {
            return await _searchSerivce.SearchByName(name);
        }
    }
}