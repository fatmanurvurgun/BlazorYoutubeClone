using BlazorComponent.Models;
using BlazorComponent.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Components
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IList<Employee> Employees { get; set; } = new List<Employee>();

        protected override async  Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        public void EmployeeSelectionChanged(int employeeId)
        {
            Console.WriteLine("Gelen employee id" + employeeId);
        }
    }
}
