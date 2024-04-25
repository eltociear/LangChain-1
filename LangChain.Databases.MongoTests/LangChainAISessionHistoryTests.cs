using Xunit;
using LangChain.Databases.Mongo.Model;

namespace LangChain.Databases.MongoTests
{
    public class LangChainAISessionHistoryTests
    {
        [Fact]
        public void SessionID_CanBeSet()
        {
            // Arrange
            var sessionHistory = new LangChainAISessionHistory();
            var sessionId = Guid.NewGuid().ToString();

            // Act
            sessionHistory.SessionID = sessionId;

            // Assert
            Assert.Equal(sessionId, sessionHistory.SessionID);
        }

        [Fact]
        public void Message_CanBeSet()
        {
            // Arrange
            var sessionHistory = new LangChainAISessionHistory();
            var message = "Test message";

            // Act
            sessionHistory.Message = message;

            // Assert
            Assert.Equal(message, sessionHistory.Message);
        }
    }
}