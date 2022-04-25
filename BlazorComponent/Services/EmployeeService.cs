using BlazorComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorComponent.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public  async Task<Employee[]> GetEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employees");
        }
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _httpClient.GetJsonAsync<Employee>("api/employees" + employeeId);
        }
    }
}
