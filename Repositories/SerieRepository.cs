using Dio.Series.Class;
using Dio.Series.Interfaces;

namespace Dio.Series.Repositories
{
    public class SerieRepository : IRepository<Serie>
    {
        #region "Properties"
        private List<Serie> serieList = new();
        #endregion

        #region "Methods"
        public List<Serie> List()
        {
            return this.serieList;
        }
        public void Insert(Serie @object)
        {
            this.serieList.Add(@object);
        }
        public void Update(int id, Serie @object)
        {
            this.serieList[id] = @object;
        }
        public void Delete(int id)
        {
            this.serieList[id].DeleteById();
        }
        public Serie GetById(int id)
        {
            return (Serie)this.serieList[id];
        }
        public int NextId()
        {
            return this.serieList.Count;
        }
        #endregion
    }
}
