using ExampleProjectDDD.Infrastructure.Models.PaymentManagment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigReadModels
{
    internal sealed partial class ConfigurationReadModel : IEntityTypeConfiguration<InvoiceReadModel>
    {
        public void Configure(EntityTypeBuilder<InvoiceReadModel> builder)
        {
            builder.ToTable("Invoice");
            builder.HasKey(i=>i.Id);
            builder.Property(i => i.DateTime).IsRequired();
            builder.Property(i => i.Amount);
            builder.Property(i => i.CourseID);
            builder.Property(i => i.UserID);
            builder.HasOne(i => i.User)
                .WithMany(u=>u.Invoices)
                .HasForeignKey(i=>i.UserID);
            builder.HasOne(i => i.Course)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i=>i.CourseID);
        }
    }
}
