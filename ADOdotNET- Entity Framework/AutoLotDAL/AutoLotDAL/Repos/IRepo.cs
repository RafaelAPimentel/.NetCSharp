using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos
{
    interface IRepo<T>
    {
        int Add(T entity);
        Task<int> AddAsync(T entity);
        int AddRange(IList<T> entities);
        Task<int> AddRangeAsync(IList<T> entities);
        int Save(T entities);
        Task<int> SaveAsync(T entities);
        int Delete(int id);
        Task<int> DeleteAsync(int id);
        int Delete(T entities);
        Task<int> DeleteAsync(T entities);
        T GetOne(int? id);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();

        List<T> ExecuteQuery(string sql);
        Task<List<T>> ExecutQueryAsync(string sql);
        List<T> ExecuteQuery(string sql, object[] sqlParametersObjects);
        Task<List<T>> ExecuteQueryAsync(string sql, object[] sqlParametersObjects);
    }
}
