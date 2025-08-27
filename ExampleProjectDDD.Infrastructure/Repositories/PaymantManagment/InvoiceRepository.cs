using ExampleProjectDDD.Domain.Entities.PaymentManagment;
using ExampleProjectDDD.Domain.Repositories.PaymentManagment;
using ExampleProjectDDD.Domain.ValueObject;
using ExampleProjectDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Repositories.PaymantManagment
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private WriteDBContext _context;
        public InvoiceRepository(WriteDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Invoice entity)
        {
            await _context.Invoices.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Invoice entity)
        {
            _context.Invoices.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Invoice>> GetAllAsync()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoice> GetAsync(BaseId Id)
        {
            return await _context.Invoices.FindAsync(Id);
        }

        public async Task UpdateAsync(Invoice entity)
        {
            _context.Invoices.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
