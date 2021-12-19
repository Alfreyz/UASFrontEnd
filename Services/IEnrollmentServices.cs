using System.Collections.Generic;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IEnrollmentServices
    {
        Task<IEnumerable<Enrollment>> GetAll(int id);
        Task <Enrollment> GetById(int id);
    }
}