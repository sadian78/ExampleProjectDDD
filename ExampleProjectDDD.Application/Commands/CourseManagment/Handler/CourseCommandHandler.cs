using ExampleProjectDDD.Application.Commands.Course;
using ExampleProjectDDD.Application.Exceptions;
using ExampleProjectDDD.Domain.Factories.CourseManagment;
using ExampleProjectDDD.Domain.Repositories.CourseManagment;
using ExampleProjectDDD.Shared.Abstraction.Commands;

namespace ExampleProjectDDD.Application.Commands.CourseManagment.Handler
{
    #region AddCourseCommandHandler
    public class AddCourseCommandHandler : ICommandHandler<AddCourseCommand>
    {
        private readonly ICourseRepository _repository;
        private readonly ICourseFactory _factory;

        public AddCourseCommandHandler(ICourseRepository repository, ICourseFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task HandlerAsync(AddCourseCommand command)
        {
            var course = _factory.CreateCourse(command.id, command.description, command.title, command.price, command.instructor_ID);
            await _repository.CreateAsync(course);
        }
    }
    #endregion

    #region UpdateCourseCommandHandler
    public class UpdateCourseCommandHandler : ICommandHandler<UpdateCourseCommand>
    {
        private readonly ICourseRepository _repository;
        private readonly ICourseFactory _factory;

        public UpdateCourseCommandHandler(ICourseRepository repository, ICourseFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task HandlerAsync(UpdateCourseCommand command)
        {
            var course = await _repository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNotFoundExcedption();
            }
            var courseF = _factory.CreateCourse(course.ID, command.description, command.title, command.price, command.instructor_ID);
            await _repository.UpdateAsync(courseF);
        }
    }
    #endregion

    #region DeleteCourseCommandHandler
    public class DeleteCourseCommandHandler : ICommandHandler<DeleteCourseCommand>
    {
        private readonly ICourseRepository _repository;
        private readonly ICourseFactory _factory;

        public DeleteCourseCommandHandler(ICourseRepository repository, ICourseFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task HandlerAsync(DeleteCourseCommand command)
        {
            var course = await _repository.GetAsync(command.id);
            if (course == null)
            {
                throw new CourseNotFoundExcedption();
            }
            await _repository.DeleteAsync(course);

        }
    }
    #endregion
}
