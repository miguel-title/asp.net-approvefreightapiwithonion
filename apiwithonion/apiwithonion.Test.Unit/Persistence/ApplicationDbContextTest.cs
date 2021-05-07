using apiwithonion.Domain.Entities;
using apiwithonion.Persistence;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace apiwithonion.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var customer = new Customer();
            context.Customers.Add(customer);
            Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
