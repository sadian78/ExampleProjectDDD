namespace ExampleProjectDDD.Application.Sevices
{
    public interface ICourseReadModelServices
    {
        Task<bool> IsExistCourseAsync(string courseName);
    }
}
