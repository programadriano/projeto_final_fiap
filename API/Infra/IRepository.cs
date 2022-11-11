using API.Entities;

namespace API.Infra
{
    public interface IRepository<T>
    {
        Result<T> Get(int page, int qtd);

        T Get(string id);

        T Create(T entity);

        void Update(string id, T entity);

        void Remove(string id);
    }
}
