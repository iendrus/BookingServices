using Application.UnitTests.Common;
using AutoMapper;
using BookingServices.Application.Industries.Commands.CreateIndustry;
using Microsoft.EntityFrameworkCore;
using Shouldly;


namespace Application.UnitTests.Industry.Commands.CreateIndustry
{
    public class CreateIndustryCommandHandlerTests : CommandTestBase
    {
        private readonly IMapper _mapper;
        private readonly CreateIndustryCommandHandler _handler;
        public CreateIndustryCommandHandlerTests() : base()
        {
            _handler = new CreateIndustryCommandHandler(_context, _mapper);
        }
            [Fact]
        public async Task Handle_GivenValidRequest_ShouldInsertIndustry()
        {

            var command = new CreateIndustryCommand()
            {
                
                Name = "Dupa",
                Description = "Blada"
               
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var industry = await _context.Industries.FirstOrDefaultAsync(x => x.Id == result, CancellationToken.None);
            industry.ShouldNotBeNull();
        }

    }
}
