using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;
using System.Linq;

namespace UAS.Pages
{
    public partial class EnrollStudents
    {
        [Parameter]
        public string id { get; set; }
        [Inject]
        public IEnrollmentServices EnrollmentServices {get;set;}
        public Enrollment enrollment { get; set; } = new Enrollment();
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            enrollment = await EnrollmentServices.GetById(int.Parse(id));
            //Student = (await StudentService.GetAll()).ToList();
        }
    }
}