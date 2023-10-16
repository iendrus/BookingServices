using Application.UnitTests.Common;
using AutoMapper;
using BookingServices.Application.Providers.Commands.CreateProvider;
using Microsoft.EntityFrameworkCore;
using Shouldly;


namespace Application.UnitTests.Provider.Commands.CreateProvider
{
    public class CreateIndustryCommandHandlerTests : CommandTestBase
    {
        private readonly IMapper _mapper;
        private readonly CreateProviderCommandHandler _handler;
        public CreateIndustryCommandHandlerTests() : base()
        {
            _handler = new CreateProviderCommandHandler(_context, _mapper);
        }
            [Fact]
        public async Task Hndle_GivenValidRequest_ShouldInsertProvider()
        {

            var command = new CreateProviderCommand()
            {
                Name = "Sielska Grupa",
                Nip = "997998999",
                IndustryId = 1,
                ContactFirstName = "Robin",
                ContactLastName = "Hood",
                EmailAddress = "rob@in.com",
                Street = "Bahama",
                City = "Lądyn",
                ZipCode = "21-225",
                Number = "65",
                Description = "Nice group"
               
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var provider = await _context.Providers.FirstOrDefaultAsync(x => x.Id == result, CancellationToken.None);
            provider.ShouldNotBeNull();
        }

    }
}
