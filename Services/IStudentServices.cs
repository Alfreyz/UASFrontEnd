using System.Collections.Generic;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IStudentServices
    {
        Task<IEnumerable<Students>> GetAll();
        Task<Students> GetById(int id);
        Task<Students> Add(Students students);
        Task<Students> Update(int id, Students students);
        Task Delete(int id);
    }
}