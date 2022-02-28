using BlazorApp.Models.pragimtech;

namespace BlazorApp.Apis.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
