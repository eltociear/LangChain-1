using LangChain.Providers.Amazon.Bedrock.Predefined.Anthropic;
using Moq;
using Xunit;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

public class AnthropicTests
{
    [Fact]
    public void ClaudeInstantV1Model_Inherits_AnthropicClaudeChatModel()
    {
        // Arrange
        var provider = new Mock<BedrockProvider>();

        // Act
        var model = new ClaudeInstantV1Model(provider.Object);

        // Assert
        Assert.IsType<AnthropicClaudeChatModel>(model);
    }

    // Add similar tests for other model classes
    // - ClaudeV2Model
    // - ClaudeV21Model
    // - Claude3SonnetModel
    // - Claude3HaikuModel
    // - Claude3OpusModel
}