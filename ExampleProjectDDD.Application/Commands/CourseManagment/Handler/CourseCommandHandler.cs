using ExampleProjectDDD.Application.Commands.Course;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.CourseManagment.Handler
{
    public class AddCourseCommandHandler : ICommandHandler<AddCourseCommand>
    {
        public Task HandlerAsync(AddCourseCommand command)
        {
            throw new NotImplementedException();
        }
    }
    public class UpdateCourseCommandHandler : ICommandHandler<UpdateCourseCommand>
    {
        public Task HandlerAsync(UpdateCourseCommand command)
        {
            throw new NotImplementedException();
        }
    }
    public class DeleteCourseCommandHandler : ICommandHandler<DeleteCourseCommand>
    {
        public Task HandlerAsync(DeleteCourseCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
