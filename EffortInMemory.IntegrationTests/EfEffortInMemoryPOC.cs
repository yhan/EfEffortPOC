using System.Threading.Tasks;
using Effort;
using NFluent;
using NSubstitute;
using NUnit.Framework;

namespace EffortInMemory.IntegrationTests
{
    public class EfEffortInMemoryPOC
    {
        static EfEffortInMemoryPOC()
        {
            //Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }

        public MyDbContext CreateInMemory()
        {
            var ctx = new MyDbContext(DbConnectionFactory.CreateTransient(),
                new DataMigrationInitializer<MyDbContext>(),
                new DotNetGuidGenerator(),
                clock: Substitute.For<IClock>(),
                null,
                null);
            ctx.Database.CreateIfNotExists();
            return ctx;
        }
        
        [Test]
        public async Task Store_company()
        {
            var dbContextResolver = Substitute.For<IResolveDbContext>();
            var context = this.CreateInMemory();
            dbContextResolver.Resolve().Returns(context);
            
            var company = new Company();

            context.Companies.Add(company);
            await context.SaveChangesAsync();

            var companyRepository = new CompanyRepository(context, new SystemUtcClock());
            var saved = companyRepository.Get(company.Id);

            Check.That(saved.Id).IsEqualTo(company.Id);
        }
    }
}
