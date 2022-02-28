using BlazorApp.Models.pragimtech;

namespace BlazorApp.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
