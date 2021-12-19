using System;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UAS.Pages;
using UAS.Services;

namespace UAS
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            var uri = new Uri("https://akademikbackend.azurewebsites.net/swagger/index.html");
            
            builder.Services.AddScoped(sp => new HttpClient{ BaseAddress = uri });
            builder.Services.AddScoped<IEnrollmentServices,EnrollmentServices>();
            builder.Services.AddScoped<IStudentServices,StudentServices>();
            await builder.Build().RunAsync();
        }
    }
}
