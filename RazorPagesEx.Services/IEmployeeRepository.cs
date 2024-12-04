using RazorPagesEx.Models;
 namespace RazorPagesEx.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int Id);
        Employee UpdateEmployee(Employee employee);
        Employee AddNewEmployee(Employee employee);
    }
}
