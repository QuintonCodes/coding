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

		public IActionResult Create() => View();

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

		public IActionResult Edit(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}

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

		public IActionResult Delete(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			_employeeService.Delete(id);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var employee = _employeeService.GetById(id);
			if (employee == null)
				return NotFound();
			return View(employee);
		}
	}
}
