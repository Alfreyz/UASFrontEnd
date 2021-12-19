using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public class StudentServices : IStudentServices
    {
        private HttpClient _httpClient;
        public StudentServices(HttpClient httpClient)
        {
              _httpClient = httpClient;
        }
        public async Task<IEnumerable<Students>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Students>>("/api/Student");
            return results;
        }

        public async Task<Students> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Students>($"/api/Student/{id}");
            return result;
        }
        public async Task<Students> Update(int id, Students students)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/Student",students);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Students>(await response.Content.ReadAsStreamAsync());
            }else{
                throw new Exception("gagal Update Student");
            }
        }
        public async Task<Students> Add(Students students)
        {
            var response = await _httpClient.PostAsJsonAsync($"/api/Student",students);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Students>(await response.Content.ReadAsStreamAsync());
            }else{
                throw new Exception("gagal Tambah Data Student");
            }
        }
        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"/api/Student/{id}");
        }
    }
}