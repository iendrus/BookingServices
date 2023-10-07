using AutoMapper;


namespace Application.UnitTests.Mapping
{
    public class Mappingtest : IClassFixture<MappingTestFixture>
    {
        private readonly IConfigurationProvider _configurationProvider;
        private readonly IMapper _mapper;
        public Mappingtest(MappingTestFixture fixture)
        {
            _configurationProvider = fixture.ConfigurationProvider;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            _configurationProvider.AssertConfigurationIsValid();

        }
    }
}
