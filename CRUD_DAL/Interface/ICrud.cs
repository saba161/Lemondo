using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.Interface
{
    public interface ICrud<T>
    {
        public Task<T> Create(T _object);

        public Task Update(T _object);

        public Task Delete(int id);

        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int Id);
    }
}