using ExampleProjectDDD.Application.DTOs.CourseManagment;
using ExampleProjectDDD.Application.DTOs.UserManagment;
using ExampleProjectDDD.Application.Models.CourseManagment;
using ExampleProjectDDD.Application.Models.UserManagmenet;

namespace ExampleProjectDDD.Application.Queries
{
    internal static class DtoMapper
    {
        public static CourseDTO ToDTO(CourseReadModel course)
        {
            return new CourseDTO()
            {
                Title = course.Title,
                Description = course.Description,
                Id = course.Id,
                Instructor_ID = course.Instructor_ID,
                Price = course.Price
            };
        }
        public static UserDTO ToDTO(UserReadModel userReadModel)
        {
            return new UserDTO()
            {
                Id = userReadModel.Id,
                Email = userReadModel.Email,
                IsConfirmed = userReadModel.IsConfirmed,
                PasswordHash = userReadModel.PasswordHash,
                UserName = userReadModel.UserName
            };
        }
    }
}
