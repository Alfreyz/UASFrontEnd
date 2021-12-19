using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EditStudents
    {
        [Parameter]
        public string id { get; set; }
        public Students Student { get; set; } = new Students();
    
        [Inject]
        public IStudentServices StudentServices {get;set;}

        [Inject]    
        public NavigationManager NavigationManager{ get; set; }
    
        protected override async Task OnInitializedAsync()
        {
            Student = await StudentServices.GetById(int.Parse(id));
        }
        protected async Task HandleValidSubmit()
        {
            NavigationManager.NavigateTo("/pageStudents");
            var result = await StudentServices.Update(int.Parse(id),Student);
        }
    }
}