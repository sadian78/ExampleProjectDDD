using ExampleProjectDDD.Application.Models.PaymentManagment;

namespace ExampleProjectDDD.Application.Models.CourseManagment
{
    public class CourseReadModel: BaseReadModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Guid Instructor_ID { get; set; }
        public InstructorReadModel Instructor { get; set; }
        public IReadOnlyList<CourseAttendeeReadModel> CourseAttendes { get; set; }
        public IReadOnlyList<CourseCatalogReadModel> CoursCataloges { get; set; }
        public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
    }
}
