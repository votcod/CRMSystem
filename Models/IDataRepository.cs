using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRMSystem.Models
{
    public interface IDataRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllData();
        Task<T> GetDataById(int dataId);
        Task CreateData(T data);
        Task UpdateDataById(int dataId);
        Task DeleteDataById(int dataId);
    }
}
