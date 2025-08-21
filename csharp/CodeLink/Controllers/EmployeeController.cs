using CodeLink.Models;
using CodeLink.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeLink.Controllers
{
	public class EmployeeController(IEmployeeService employeeService) : Controller
	{
		private readonly IEmployeeService _employeeService = employeeService;

		public IActionResult Index()
		{
			var employees = _employeeService.GetAll();
			return View(employees);
		}

		// GET: Employee
		public IActionResult Create() => View();

		// GET: Employee/Create
		[HttpPost]
		public IActionResult Create(Employee employee)
		{
			if (ModelState.IsValid)
			{
				_employeeService.Add(employee);
				return RedirectToAction(nameof(Index));
			}
			return View(employee);
		}

		// GET: Employee/Edit
		public IActionResult Edit(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}

		// POST: Employee/Edit
		[HttpPost]
		public IActionResult Edit(Employee employee)
		{
			if (ModelState.IsValid)
			{
				_employeeService.Update(employee);
				return RedirectToAction(nameof(Index));
			}
			return View(employee);
		}

		// GET: Employee/Delete
		public IActionResult Delete(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}

		// POST: Employee/Delete
		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			_employeeService.Delete(id);
			return RedirectToAction(nameof(Index));
		}

		// GET: Employee/Details
		public IActionResult Details(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}
	}
}
