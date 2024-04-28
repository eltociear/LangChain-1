using LangChain.Providers.Amazon.Bedrock.Chat.Settings;
using Xunit;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

public class AnthropicChatSettingsTests
{
    [Fact]
    public void Calculate_UsesDefaultSettings_WhenNoOverridesProvided()
    {
        // Arrange

        // Act
        var settings = AnthropicChatSettings.Calculate(
            requestSettings: null,
            modelSettings: null,
            providerSettings: null);

        // Assert
        Assert.Equal(AnthropicChatSettings.Default.StopSequences, settings.StopSequences);
        Assert.Equal(AnthropicChatSettings.Default.User, settings.User);
        Assert.Equal(AnthropicChatSettings.Default.UseStreaming, settings.UseStreaming);
        Assert.Equal(AnthropicChatSettings.Default.Temperature, settings.Temperature);
        Assert.Equal(AnthropicChatSettings.Default.MaxTokens, settings.MaxTokens);
        Assert.Equal(AnthropicChatSettings.Default.TopP, settings.TopP);
        Assert.Equal(AnthropicChatSettings.Default.TopK, settings.TopK);
    }

    // Add more tests to cover overrides at request, model and provider level
}