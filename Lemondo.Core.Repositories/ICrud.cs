using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lemondo.Core.Repositories
{
    public interface ICrud<T>
    {
        public Task Create(T _object);

        public Task Update(T _object);

        public Task Delete(int id);

        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int Id);
    }
}