namespace API.ApiModel
{
    public class TeacherAndClassRoomApiModel
    {
        public List<ClassRoomApiModel> ClassRoomList { get; set; }
        public TeacherApiModel Teacher { get; set; }
    }
}
