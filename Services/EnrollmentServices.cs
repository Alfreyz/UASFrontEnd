using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public class EnrollmentServices : IEnrollmentServices
    {
        private HttpClient _httpClient;
        public EnrollmentServices(HttpClient httpClient)
        {
              _httpClient = httpClient;
        }
        public async Task<IEnumerable<Enrollment>> GetAll(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>($"/enrollment/{id}");
            return results;
        }
        public async Task<Enrollment> GetById(int id)
        {
           var result = await _httpClient.GetFromJsonAsync<Enrollment>($"/enrollment/{id}");
           return result;
        }
    }
}