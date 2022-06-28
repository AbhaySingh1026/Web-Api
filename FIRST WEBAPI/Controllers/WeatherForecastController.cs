using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FIRST_WEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class WeatherForecastController : ControllerBase
    {
    //    private static readonly string[] Summaries = new[]
    //    {
    //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //};

        private readonly ILogger<WeatherForecastController> _logger;
        private List<Employee> employees = new List<Employee>
        {
            new Employee{Id=1,Name="Abhay Singh",Age=21,Designation="DotNet Developer",JoiningDate= Convert.ToDateTime("24/06/2022")},
            new Employee{Id=2,Name="SriAnanda Panda",Age=22,Designation="Java Developer",JoiningDate= Convert.ToDateTime("23/06/2022")}

        };
        //private string DoWork(string name,string designation)
        //{
        //    return $"{name} is {designation} Developer.";
        //}
        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        ////[HttpGet]
        ////public ActionResult Get()
        ////{
        ////    string name = "Abhay";
        ////    string designation = "DotNet";
        ////    return Ok(DoWork(name,designation));
        ////}
        ////[HttpGet]
        ////public ActionResult Get2()
        ////{
        ////    string name = "Panda";
        ////    string designation = "Java";
        ////    return Ok(DoWork(name, designation));
        ////}//weatherforecast

        //[HttpGet]
        //public ActionResult ShowAllEmp()
        //{
        //    return Ok(employees);
        //}
        //[HttpGet]
        //public ActionResult ShowEmpById()
        //{
        //    return Ok(employees.Where(x => x.Id == 1).FirstOrDefault());
        //}
        //[HttpPost]
        //public ActionResult AddEmp()
        //{
        //    Employee employee = new Employee { Id = 3, Name = "Himanshu Mishra", Age = 23, Designation = "Doctor", JoiningDate = Convert.ToDateTime("24/06/2022") };
        //    employees.Add(employee);
        //    return Ok(employees);
        //}
        //[HttpPut]
        //public ActionResult UpdateAllFieldsOfOneEmp()
        //{
        //    var emp = employees.Where(x => x.Id == 2).FirstOrDefault();
        //    emp.Id = 3;
        //    emp.Name = "Shobhit Yadav";
        //    emp.Age = 25;
        //    emp.Designation = "Python Developer";
        //    emp.JoiningDate = Convert.ToDateTime("25/06/2022");
        //    return Ok(employees);
        //}
        //[HttpPatch]
        //public ActionResult UpdateOneFieldOfOneEmp()
        //{
        //    var emp = employees.Where(x => x.Id == 2).FirstOrDefault();
        //    emp.Id = 2000;
        //    return Ok(employees);
        //}
        //[HttpDelete]
        //public ActionResult DeleteOneEmp()
        //{
        //    var emp = employees.Where(x => x.Id == 2).FirstOrDefault();
        //    employees.Remove(emp);
        //    return Ok(employees);
        //}

        //------------------------------------Making same above methods with query string(URI) and body approach----------------------------------------------

        [HttpPost]
        public ActionResult InsertEmp([System.Web.Http.FromBody] Employee employee)
        {
            if (employee == null) return NoContent();
            else
            {
                //employee.JoiningDate =  Convert.ToDateTime(employee.JoiningDate);
                employees.Add(employee);
                return Ok(employees);
            }
        }
        [HttpPut]
        public ActionResult UpdateEmp([System.Web.Http.FromUri] int id, [System.Web.Http.FromBody] Employee employee)
        {
            if (employees == null) return NoContent();
            var extract = employees.Where(x => x.Id == id).FirstOrDefault();
            if (extract == null) return NotFound();
            extract.Id = employee.Id;
            extract.Name = employee.Name;
            extract.Age = employee.Age;
            extract.Designation = employee.Designation;
            extract.JoiningDate = Convert.ToDateTime(employee.JoiningDate);
            return Ok(employees);
        }
        [HttpDelete]
        public ActionResult DeleteEmp([System.Web.Http.FromUri] int id)
        {
            if (employees == null) return NoContent();
            var extract = employees.Where(x => x.Id == id).FirstOrDefault();
            if (extract == null) return NotFound();
            employees.Remove(extract);
            return Ok(employees);
        }
        [HttpGet]
        public ActionResult ShowOneEmp([System.Web.Http.FromUri] int id)
        {
            if (employees == null) return NoContent();
            var extract = employees.Where(x => x.Id == id).FirstOrDefault();
            if (extract == null) return NotFound();
            return Ok(extract);
        }
        //[HttpGet]
        //public ActionResult GetFromUri()
        //{
        //    Employee employee = new Employee();
        //    employee.Id = 100;
        //    employee.Name = "XYZ";
        //    employee.Age = 45;
        //    employee.Designation = "ABC";
        //    employee.JoiningDate = DateTime.Now;
        //    var serializedOutput = JsonConvert.SerializeObject(employee);
        //    return Ok(serializedOutput);
        //}
    }
}