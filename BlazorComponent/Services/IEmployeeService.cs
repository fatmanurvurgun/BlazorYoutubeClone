using BlazorComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Services
{
    public interface IEmployeeService
    {
        Task<Employee[]> GetEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
