using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEx.Models;
using RazorPagesEx.Services;

namespace RazorPagesEx.Pages.Employees
{
    public class EditModel : PageModel
    {
        //[BindProperty]
        public Employee Employee;

        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult OnGet(int id)
        {

            Employee = _employeeRepository.GetEmployeeById(id);
            if (Employee == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            if (employee == null)
            {
                return RedirectToPage("/Error");
            }
            _employeeRepository.UpdateEmployee(employee);
            return Page();
        }
    }
}
 