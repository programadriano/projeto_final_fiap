using API.Entities;

namespace API.Infra
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Result<T> Get(int page, int qtd)
        {
            throw new NotImplementedException();
        }

        public T Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
