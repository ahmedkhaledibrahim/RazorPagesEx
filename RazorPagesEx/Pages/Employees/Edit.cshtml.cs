using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEx.Models;
using RazorPagesEx.Services;

namespace RazorPagesEx.Pages.Employees
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public bool Notify { get; set; }

        public string Message { get; set; }

        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult OnGet(int? id)
        {
            if (id != null && id > 0)
            {
                Employee = _employeeRepository.GetEmployeeById(id ?? 0);
                if (Employee == null)
                {
                    return RedirectToPage("/Error");
                }
                return Page();
            }
            else
            {
                Employee = new Employee();
                return Page();
            }
        }

        public IActionResult OnPost(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee == null)
                {
                    return RedirectToPage("/Error");
                }
                if (employee.Id == 0)
                {
                    _employeeRepository.AddNewEmployee(employee);
                }
                else
                {
                    _employeeRepository.UpdateEmployee(employee);
                }
                return Page();

            }
            else
            {
                return Page();
            }

        }

        public void OnPostNotificationPreferneces()
        {
            if (Notify)
            {
                Message = "Thanks for the notification";
            }
            else
            {
                Message = "You have turned off notifications";
            }
            Employee = _employeeRepository.GetEmployeeById(Employee.Id);
        }
    }
}
 