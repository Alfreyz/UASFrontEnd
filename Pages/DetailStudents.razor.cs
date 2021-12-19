using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DetailStudents
    {
        [Parameter]
        public string id { get; set; }
        [Inject]
        public IStudentServices StudentServices { get; set; }
        public Students Student { get; set; } = new Students();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentServices.GetById(int.Parse(id));
        }
    }
}