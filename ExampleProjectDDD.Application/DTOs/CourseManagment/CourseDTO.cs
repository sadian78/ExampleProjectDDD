namespace ExampleProjectDDD.Application.DTOs.CourseManagment
{
    public class CourseDTO
    {
        public Guid Id { get; set; }
        public Guid Instructor_ID { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
    public class CouesesListDTO
    {
        public IEnumerable<CourseDTO> Courses { get; set; }
    }
}
