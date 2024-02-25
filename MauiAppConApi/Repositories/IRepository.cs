
namespace MauiAppConApi.Repositories;

internal interface IRepository<T>
{
    public T GetById(int id);
    public List<T> GetAll();
}
