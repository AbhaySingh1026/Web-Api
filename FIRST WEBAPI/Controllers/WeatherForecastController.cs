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

        //[HttpPost]
        //public ActionResult InsertEmp([System.Web.Http.FromBody] Employee employee) //u don't hv to use this sys.web.etc coz its a older thing used in older framwrks bt here in .net6 u can use
        //                                                                            //directly [FromBody/uri/etc]. & also for using tht older 1 u have to intall a package Microsoft.AspNet.WebApi.Core & also this doesn'nt supports custom datatype in URI.
        //{
        //    if (employee == null) return NoContent();
        //    else
        //    {
        //        employees.Add(employee);
        //        return Ok(employees);
        //    }
        //}
        //[HttpPut]
        //public ActionResult UpdateEmp(int id, [FromQuery] Employee employee) //by default for .net defined datatyps input is fromURI & for custom datatyps its fromBODY.so if u pass nthing it will take as default one
        //    //bt u can explicitly change default value to any other typ. like here i did for emp whose default was frombody bt i changed 2 fromURL.
        //{
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    extract.Id = employee.Id;
        //    extract.Name = employee.Name;
        //    extract.Age = employee.Age;
        //    extract.Designation = employee.Designation;
        //    extract.JoiningDate = Convert.ToDateTime(employee.JoiningDate);
        //    return Ok(employees);
        //}
        //[HttpDelete]
        //public ActionResult DeleteEmp([FromBody] int id) //in body for if passing value of .netdefined datatyp then only write its value, bt if passing for an customdefined datatyp like obj
        //{                                                //then write all its properties with its values in JSON format
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    employees.Remove(extract);
        //    return Ok(employees);
        //}
        //[HttpGet]
        //public ActionResult ShowOneEmp([System.Web.Http.FromUri] int id) //In newer version this FromURI is known as fromQuery
        //{
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    return Ok(extract);
        //}
        ////[HttpGet]
        ////public ActionResult GetFromUri()
        ////{
        ////    Employee employee = new Employee();
        ////    employee.Id = 100;
        ////    employee.Name = "XYZ";
        ////    employee.Age = 45;
        ////    employee.Designation = "ABC";
        ////    employee.JoiningDate = DateTime.Now;
        ////    var serializedOutput = JsonConvert.SerializeObject(employee);
        ////    return Ok(serializedOutput);
        ////}

        //------------------------------------------------Same upper methods in FromHeader & FromRoute--------------------------------------------

        //[HttpPost("{id}/{name}/{age}/{designation}/{joiningdate}")] //how many variabl u r writing here u must pass values for all in postman/swagger otherwise it will show err
        //public ActionResult InsertEmp([FromRoute] Employee employee) //u can't use [FromHeader] for customDatatyp (obj)                                             
        //{
        //    if (employee == null) return NoContent();
        //    else
        //    {
        //        employees.Add(employee);
        //        return Ok(employees);
        //    }
        //}
        //[HttpPut("{id}/{employee.id}/{employee.name}/{employee.age}/{employee.designation}/{employee.joiningdate}")]
        //public ActionResult UpdateEmp([FromRoute] int id, [FromRoute] Employee employee)                                                                     
        //{
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    extract.Id = employee.Id;
        //    extract.Name = employee.Name;
        //    extract.Age = employee.Age;
        //    extract.Designation = employee.Designation;
        //    extract.JoiningDate = Convert.ToDateTime(employee.JoiningDate);
        //    return Ok(employees);
        //}
        //[HttpDelete]
        //public ActionResult DeleteEmp([FromHeader] int id) 
        //{                                                
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    employees.Remove(extract);
        //    return Ok(employees);
        //}
        //[HttpGet]
        //public ActionResult ShowOneEmp([FromHeader] int id) 
        //{
        //    if (employees == null) return NoContent();
        //    var extract = employees.Where(x => x.Id == id).FirstOrDefault();
        //    if (extract == null) return NotFound();
        //    return Ok(extract);
        //}
        ////[HttpGet]
        ////public ActionResult HeaderForMoreThan1Value([FromHeader]int id,[FromHeader]string name) //how many variabl u r writing here u must pass values for all in postman/swagger otherwise it will show err
        ////{
        ////    return Ok($"Id is - {id}, Name is - {name}");
        ////}

        //---------------------------------For initializing more than 1 custom datatypes(user defined obj) in body -------------------------------------

        //[HttpGet]
        //public ActionResult Check([FromBody] Employee obj, [FromBody] Organization obj1)  //This will give err
        //{
        //    return Ok();
        //}

        //[HttpGet]
        //public ActionResult InsertEmployeeAndOrg([FromBody] EmployeePlusOrganization obj) //by using this approach u can pass data to more than 1 obj of diff classes in body
        //{
        //    return Ok($"Emp Name is {obj.Employee.Name}, Emp Pre. working company was - {obj.Organization.Name}");
        //    //return Ok(obj); //It will return data(combined obj of emp. & org class)(list) in json format automatically.i.e when u return a list type data it automatically presents in JSON format
        //}

        //passed obj in postman - {"employee":{"id":1,"name":"Abhay","age":21,"designation":"developer","joiningdate":"2022-06-27"},"organization":{"id":101,"name":"Google","empid":1}}
    }
}