using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEx.Models;
using RazorPagesEx.Services;

namespace RazorPagesEx.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();

        private readonly IEmployeeRepository _employeeRepository;
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void OnGet()
        {
             Employees = _employeeRepository.GetAllEmployees();
        }
    }
}
