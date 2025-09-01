using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Application.Models.CourseManagment;

namespace ExampleProjectDDD.Application.Sevices
{
    public interface ICourseReadModelServices
    {
        Task<bool> IsExistCourseAsync(string courseName);
        Task<CourseReadModel> GetCourseByIdAsync(Guid id);
        Task<IEnumerable<CourseReadModel>> GetCoursesAsync();
        Task<IEnumerable<CourseReadModel>> GetCoursesByPhraseAsync(string phrase);
    }
}
