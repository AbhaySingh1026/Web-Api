using Microsoft.AspNetCore.Mvc;

namespace FIRST_WEBAPI
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Designation { get; set; }
        public DateTime JoiningDate { get; set; }
    }
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int EmpId { get; set; }
    }
    public class EmployeePlusOrganization
    {
        public Employee Employee { get; set; }
        public Organization Organization { get; set; }
    }
}
