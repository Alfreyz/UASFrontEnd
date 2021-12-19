using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DeleteStudents
    {
        [Parameter]
        public string id { get; set; }
    
        [Inject]
        public IStudentServices StudentServices {get;set;}

        [Inject]    
        public NavigationManager NavigationManager{ get; set; }

        
        protected async override Task OnInitializedAsync()
        {
            await StudentServices.Delete(int.Parse(id));
            NavigationManager.NavigateTo("/pageStudents");
        }
    }
}