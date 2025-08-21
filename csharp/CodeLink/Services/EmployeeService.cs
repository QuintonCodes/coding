using CodeLink.Models;

namespace CodeLink.Services
{
	public interface IEmployeeService
	{
		List<Employee> GetAll();
		Employee? GetById(int id);
		void Add(Employee employee);
		void Update(Employee employee);
		void Delete(int id);
	}

	public class EmployeeService : IEmployeeService
	{
		private readonly List<Employee> _employees = [];
		private int _nextId = 1;
		public List<Employee> GetAll() => _employees;

		public Employee? GetById(int id) => _employees.FirstOrDefault(e => e.EmployeeId == id);

		public void Add(Employee employee)
		{
			ArgumentNullException.ThrowIfNull(employee);
			employee.EmployeeId = _nextId++;
			_employees.Add(employee);
		}
		public void Update(Employee employee)
		{
			ArgumentNullException.ThrowIfNull(employee);
			var existingEmployee = GetById(employee.EmployeeId);
			if (existingEmployee != null)
			{
				existingEmployee.FullName = employee.FullName;
				existingEmployee.EmailAddress = employee.EmailAddress;
				existingEmployee.JobTitle = employee.JobTitle;
				existingEmployee.Department = employee.Department;
			}
		}
		public void Delete(int id)
		{
			var employee = GetById(id);
			if (employee != null)
				_employees.Remove(employee);
		}
	}
}
