using ExampleProjectDDD.Domain.Primitives;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Course;

namespace ExampleProjectDDD.Domain.Entities.CourseManagment
{
    public class Lesson : BaseEntity
    {

        internal Lesson(BaseId id,Title title, Content content, BaseId courseCatalogID):base(id)
        {
            _title = title;
            _content = content;
            _courseCatalogID = courseCatalogID;
        }
        public Lesson(BaseId id) : base(id) { }


        private Title _title;
        private Content _content;
        private BaseId _courseCatalogID;
    }
}
