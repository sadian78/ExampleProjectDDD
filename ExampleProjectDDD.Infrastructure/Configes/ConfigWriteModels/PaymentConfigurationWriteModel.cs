using ExampleProjectDDD.Domain.Entities.CourseManagment;
using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.Entities.UserManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Domain.ValueObject.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExampleProjectDDD.Infrastructure.Configes.ConfigWriteModels
{
    internal sealed partial class ConfigurationWriteModel : IEntityTypeConfiguration<Invoice>
    {
        private ValueConverter amountConvertor = new ValueConverter<Amount, decimal>(amount => amount.Value, amount => new Amount(amount));

        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasConversion(idConvertor);

            builder.Property(typeof(Amount), "_amount")
                .HasConversion(amountConvertor)
                .HasColumnName("Amount");

            builder.Property(typeof(DateTime), "_date")
                .HasColumnName("Date")
                .IsRequired();

            builder.Property(typeof(BaseId), "_userID")
                .HasColumnName("UserID")
                .IsRequired();

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey("_userID");

            builder.Property(typeof(BaseId), "_courseID")
               .HasColumnName("CourseID")
               .IsRequired();

            builder.HasOne<Course>()
               .WithMany()
               .HasForeignKey("_courseID");
        }
    }
}
