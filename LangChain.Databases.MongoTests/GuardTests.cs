using Xunit;
using LangChain.Databases.Mongo;

namespace LangChain.Databases.MongoTests
{
    public class GuardTests
    {
        [Fact]
        public void AgainstNullArgument_ThrowsArgumentNullException_WhenNull()
        {
            // Arrange
            string nullArg = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Guard.AgainstNullArgument(nullArg, nameof(nullArg)));
        }

        [Fact]
        public void AgainstNullArgument_DoesNotThrow_WhenNotNull()
        {
            // Arrange
            string notNullArg = "some value";

            // Act & Assert
            Guard.AgainstNullArgument(notNullArg, nameof(notNullArg));
        }
    }
}