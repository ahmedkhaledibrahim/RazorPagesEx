using RazorPagesEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesEx.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>();

        static MockEmployeeRepository()
        {
             employees = [
                new Employee { Id = 1, Name = "John Doe", Email = "john.doe@example.com", ImageUrl = "image1.jpg", Department = Dept.IT },
                new Employee { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", ImageUrl = "image2.jpg", Department = Dept.HR },
                new Employee { Id = 3, Name = "Robert Brown", Email = "robert.brown@example.com", ImageUrl = "image3.jpg", Department = Dept.Payroll },
                new Employee { Id = 4, Name = "Emily Johnson", Email = "emily.johnson@example.com", ImageUrl = "image4.jpg", Department = Dept.IT },
                new Employee { Id = 5, Name = "Michael White", Email = "michael.white@example.com", ImageUrl = "image5.jpg", Department = Dept.None },
                new Employee { Id = 6, Name = "Laura Adams", Email = "laura.adams@example.com", ImageUrl = "image6.jpg", Department = Dept.HR },
                new Employee { Id = 7, Name = "David Clark", Email = "david.clark@example.com", ImageUrl = "image7.jpg", Department = Dept.IT },
                new Employee { Id = 8, Name = "Sophia Turner", Email = "sophia.turner@example.com", ImageUrl = "image8.jpg", Department = Dept.Payroll },
                new Employee { Id = 9, Name = "James Hill", Email = "james.hill@example.com", ImageUrl = "image9.jpg", Department = Dept.None },
                new Employee { Id = 10, Name = "Olivia Martin", Email = "olivia.martin@example.com", ImageUrl = "image10.jpg", Department = Dept.HR },
                new Employee { Id = 11, Name = "Daniel Walker", Email = "daniel.walker@example.com", ImageUrl = "image11.jpg", Department = Dept.IT },
                new Employee { Id = 12, Name = "Charlotte Allen", Email = "charlotte.allen@example.com", ImageUrl = "image12.jpg", Department = Dept.Payroll },
                new Employee { Id = 13, Name = "Benjamin Scott", Email = "benjamin.scott@example.com", ImageUrl = "image13.jpg", Department = Dept.IT },
                new Employee { Id = 14, Name = "Emma Harris", Email = "emma.harris@example.com", ImageUrl = "image14.jpg", Department = Dept.None },
                new Employee { Id = 15, Name = "Matthew Lewis", Email = "matthew.lewis@example.com", ImageUrl = "image15.jpg", Department = Dept.HR },
                new Employee { Id = 16, Name = "Amelia King", Email = "amelia.king@example.com", ImageUrl = "image16.jpg", Department = Dept.Payroll },
                new Employee { Id = 17, Name = "Christopher Wright", Email = "christopher.wright@example.com", ImageUrl = "image17.jpg", Department = Dept.IT },
                new Employee { Id = 18, Name = "Isabella Lopez", Email = "isabella.lopez@example.com", ImageUrl = "image18.jpg", Department = Dept.HR },
                new Employee { Id = 19, Name = "Andrew Green", Email = "andrew.green@example.com", ImageUrl = "image19.jpg", Department = Dept.None },
                new Employee { Id = 20, Name = "Mia Hall", Email = "mia.hall@example.com", ImageUrl = "image20.jpg", Department = Dept.Payroll },
                new Employee { Id = 21, Name = "Joseph Young", Email = "joseph.young@example.com", ImageUrl = "image21.jpg", Department = Dept.IT },
                new Employee { Id = 22, Name = "Evelyn Hernandez", Email = "evelyn.hernandez@example.com", ImageUrl = "image22.jpg", Department = Dept.HR },
                new Employee { Id = 23, Name = "Ryan King", Email = "ryan.king@example.com", ImageUrl = "image23.jpg", Department = Dept.IT },
                new Employee { Id = 24, Name = "Ava Robinson", Email = "ava.robinson@example.com", ImageUrl = "image24.jpg", Department = Dept.Payroll },
                new Employee { Id = 25, Name = "Anthony Campbell", Email = "anthony.campbell@example.com", ImageUrl = "image25.jpg", Department = Dept.None },
                new Employee { Id = 26, Name = "Liam Mitchell", Email = "liam.mitchell@example.com", ImageUrl = "image26.jpg", Department = Dept.IT },
                new Employee { Id = 27, Name = "Sophia Carter", Email = "sophia.carter@example.com", ImageUrl = "image27.jpg", Department = Dept.HR },
                new Employee { Id = 28, Name = "Noah Phillips", Email = "noah.phillips@example.com", ImageUrl = "image28.jpg", Department = Dept.Payroll },
                new Employee { Id = 29, Name = "Victoria Evans", Email = "victoria.evans@example.com", ImageUrl = "image29.jpg", Department = Dept.None },
                new Employee { Id = 30, Name = "Jackson Ward", Email = "jackson.ward@example.com", ImageUrl = "image30.jpg", Department = Dept.IT },
                new Employee { Id = 31, Name = "Chloe Rivera", Email = "chloe.rivera@example.com", ImageUrl = "image31.jpg", Department = Dept.HR },
                new Employee { Id = 32, Name = "Samuel Baker", Email = "samuel.baker@example.com", ImageUrl = "image32.jpg", Department = Dept.Payroll },
                new Employee { Id = 33, Name = "Grace Parker", Email = "grace.parker@example.com", ImageUrl = "image33.jpg", Department = Dept.IT },
                new Employee { Id = 34, Name = "Caleb Nelson", Email = "caleb.nelson@example.com", ImageUrl = "image34.jpg", Department = Dept.None },
                new Employee { Id = 35, Name = "Ella Perez", Email = "ella.perez@example.com", ImageUrl = "image35.jpg", Department = Dept.HR },
                new Employee { Id = 36, Name = "Gabriel Moore", Email = "gabriel.moore@example.com", ImageUrl = "image36.jpg", Department = Dept.Payroll },
                new Employee { Id = 37, Name = "Hannah Bell", Email = "hannah.bell@example.com", ImageUrl = "image37.jpg", Department = Dept.IT },
                new Employee { Id = 38, Name = "Elijah Morris", Email = "elijah.morris@example.com", ImageUrl = "image38.jpg", Department = Dept.HR },
                new Employee { Id = 39, Name = "Abigail Cook", Email = "abigail.cook@example.com", ImageUrl = "image39.jpg", Department = Dept.None },
                new Employee { Id = 40, Name = "Lucas Ross", Email = "lucas.ross@example.com", ImageUrl = "image40.jpg", Department = Dept.IT },
                new Employee { Id = 41, Name = "Zoe Rogers", Email = "zoe.rogers@example.com", ImageUrl = "image41.jpg", Department = Dept.HR },
                new Employee { Id = 42, Name = "Nathan Price", Email = "nathan.price@example.com", ImageUrl = "image42.jpg", Department = Dept.Payroll },
                new Employee { Id = 43, Name = "Scarlett Bryant", Email = "scarlett.bryant@example.com", ImageUrl = "image43.jpg", Department = Dept.IT },
                new Employee { Id = 44, Name = "Owen Foster", Email = "owen.foster@example.com", ImageUrl = "image44.jpg", Department = Dept.None },
                new Employee { Id = 45, Name = "Lily Bennett", Email = "lily.bennett@example.com", ImageUrl = "image45.jpg", Department = Dept.HR },
                new Employee { Id = 46, Name = "Ethan Diaz", Email = "ethan.diaz@example.com", ImageUrl = "image46.jpg", Department = Dept.IT },
                new Employee { Id = 47, Name = "Madison Simmons", Email = "madison.simmons@example.com", ImageUrl = "image47.jpg", Department = Dept.Payroll },
                new Employee { Id = 48, Name = "Logan Howard", Email = "logan.howard@example.com", ImageUrl = "image48.jpg", Department = Dept.HR },
                new Employee { Id = 49, Name = "Aria Wood", Email = "aria.wood@example.com", ImageUrl = "image49.jpg", Department = Dept.IT },
                new Employee { Id = 50, Name = "Dylan Brooks", Email = "dylan.brooks@example.com", ImageUrl = "image50.jpg", Department = Dept.Payroll }
            ];

        }

        public Employee AddNewEmployee(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return employees.Where(e => e.Id == Id).FirstOrDefault();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = employees.Where(e => e.Id == employee.Id).FirstOrDefault();
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Email = employee.Email;
                existingEmployee.ImageUrl = employee.ImageUrl;
                existingEmployee.Department = employee.Department;
                
            }
            return existingEmployee;
        }


    }
}
