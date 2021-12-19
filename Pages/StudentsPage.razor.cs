using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class StudentsPage
    {
        public List<Students> Student { get; set; } = new List<Students>();
        [Inject]
        public IStudentServices StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Student = (await StudentService.GetAll()).ToList();
        }
    }
}