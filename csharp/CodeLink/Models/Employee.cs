namespace CodeLink.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string FullName { get; set; } = string.Empty;
		public string EmailAddress { get; set; } = string.Empty;
		public string JobTitle { get; set; } = string.Empty;
		public string Department { get; set; } = string.Empty;
	}
}
