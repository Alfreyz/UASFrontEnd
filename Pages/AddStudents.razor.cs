using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class AddStudents
    {
        public Students Student { get; set; } = new Students();
    
        [Inject]
        public IStudentServices StudentServices {get;set;}

        [Inject]    
        public NavigationManager NavigationManager{ get; set; }

        protected async Task HandleValidSubmit()
        {
            NavigationManager.NavigateTo("/pageStudents");
            var result = await StudentServices.Add(Student);
        }
    }
}