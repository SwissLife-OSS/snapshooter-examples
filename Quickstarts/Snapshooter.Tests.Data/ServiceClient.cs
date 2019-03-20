using System;
using System.Threading.Tasks;

namespace Snapshooter.Tests.Data
{
    public class ServiceClient
    {
		public TestPerson CreatePerson(Guid id, string firstName, string lastName)
        {
            return TestPersonBuilder.Create()
                .WithId(id)
                .WithFirstname(firstName)
                .WithLastname(lastName)
                .Build();
        }

        public async Task<TestPerson> CreatePersonAsync(Guid id, string firstName, string lastName)
        {
            await Task.Delay(10);

            TestPerson person = TestPersonBuilder.Create()
                .WithId(id)
                .WithFirstname(firstName)
                .WithLastname(lastName)
                .Build();

            await Task.Delay(10);

            return person;
        }

        public TestPerson CreatePerson(string firstName, string lastName)
        {
            return TestPersonBuilder.Create()
                .WithId(Guid.NewGuid())
                .WithFirstname(firstName)
                .WithLastname(lastName)
                .Build();
        }
    }
}
