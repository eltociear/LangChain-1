using Xunit;
using Moq;
using LangChain.Databases.Mongo.Client;

namespace LangChain.Databases.MongoTests
{
    public class MongoContextTests
    {
        private readonly Mock<IDatabaseConfiguration> _mockConfig;
        private readonly MongoContext _context;

        public MongoContextTests()
        {
            _mockConfig = new Mock<IDatabaseConfiguration>();
            _context = new MongoContext(_mockConfig.Object);
        }

        [Fact]
        public void GetCollection_ReturnsMongoCollection()
        {
            // Arrange
            _mockConfig.Setup(c => c.ConnectionString).Returns("mongodb://localhost:27017");
            _mockConfig.Setup(c => c.DatabaseName).Returns("testdb");

            // Act
            var collection = _context.GetCollection<BaseEntity>();

            // Assert
            Assert.NotNull(collection);
            _mockConfig.Verify(c => c.ConnectionString, Times.Once);
            _mockConfig.Verify(c => c.DatabaseName, Times.Once);
        }
    }
}