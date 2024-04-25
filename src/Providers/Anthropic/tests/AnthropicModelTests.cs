using Anthropic.SDK.Messaging;
using LangChain.Providers.Anthropic;
using Xunit;

namespace LangChain.Providers.Anthropic.Tests;

public class AnthropicModelTests
{
    [Fact]
    public void ToRequestMessage_ReturnsExpectedMessageForHumanRole()
    {
        // Arrange
        var message = new Message("test content", MessageRole.Human);

        // Act
        var result = AnthropicModel.ToRequestMessage(message);

        // Assert
        Assert.Equal(RoleType.User, result.Role);
        Assert.Single(result.Content);
        Assert.Equal("test content", ((TextContent)result.Content[0]).Text);
    }

    // Add similar tests for MessageRole.Ai, MessageRole.System cases
    // Test that MessageRole.FunctionCall and MessageRole.FunctionResult throw NotImplementedException
}