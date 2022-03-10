namespace Dio.Series.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        int NextId();
    }
}
