using API.ApiModel;
using AutoMapper;
using CONNECT_API_TO_DB;
using CONNECT_API_TO_DB.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ApiDbContext _context;
        private readonly IMapper _mapper;
        public TeachersController(ApiDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
          if (_context.Teachers == null)
          {
              return NoContent();
          }
            var teacherList =  _context.Teachers.Include(c => c.ClassRooms).ToList();
            return teacherList;
        }

        [HttpGet("{teacherId}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int teacherId)
        {
          if (_context.Teachers == null)
          {
              return NoContent();
          }
            var teacher = _context.Teachers.Where(t => t.Id == teacherId).Include(c => c.ClassRooms).FirstOrDefault();
            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
        }

        [HttpPut("{teacherId}")]
        public async Task<ActionResult<Teacher>> PutTeacher(int teacherId, TeacherAndClassRoomApiModel teacherAndClassRoom)
        {
            if (_context.Teachers == null)
            {
                return NoContent();
            }
            var updateTeacher = _context.Teachers.Where(t => t.Id == teacherId).Include(c => c.ClassRooms).FirstOrDefault();
            if (updateTeacher == null)
            {
                return NotFound();
            }
            updateTeacher.Name = teacherAndClassRoom.Teacher.Name;
            updateTeacher.ClassRooms = _mapper.Map<List<ClassRoom>>(teacherAndClassRoom.ClassRoomList);
            _context.Teachers.Update(updateTeacher);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(TeacherAndClassRoomApiModel teacherAndClassRoom)
        {
          if (_context.Teachers == null)
          {
              return NoContent();
          }
            //Teacher teacherObj = new Teacher();
            //teacherObj.Name = teacherAndClassRoom.Teacher.Name;
            //List<ClassRoom> classRoomsList = new List<ClassRoom>(); 
            //foreach(var item in teacherAndClassRoom.ClassRoomList)
            //{
            //    classRoomsList.Add(new ClassRoom { Name = item.Name});
            //}
            var teacher = _mapper.Map<Teacher>(teacherAndClassRoom.Teacher);
            var classroomList = _mapper.Map<List<ClassRoom>>(teacherAndClassRoom.ClassRoomList);
            teacher.ClassRooms = classroomList;
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{teacherId}")]
        public async Task<IActionResult> DeleteTeacher(int teacherId)
        {
            if (_context.Teachers == null)
            {
                return NoContent();
            }
            var teacher = await _context.Teachers.FindAsync(teacherId);
            if (teacher == null)
            {
                return NotFound();
            }
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPatch("{teacherId}")]
        public async Task<IActionResult> PatchTeacher(int teacherId, Tuple<string> tuple)
        {
            if(_context.Teachers == null)
            {
                return NoContent();
            }
            var teacher = await _context.Teachers.FindAsync(teacherId);
            if(teacher == null)
            {
                return NotFound();
            }
            teacher.Name = tuple.Item1;
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}