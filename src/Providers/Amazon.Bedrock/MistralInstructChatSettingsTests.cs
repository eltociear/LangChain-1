using LangChain.Providers.Amazon.Bedrock.Chat.Settings;
using Xunit;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

public class MistralInstructChatSettingsTests
{
    [Fact]
    public void Calculate_UsesDefaultSettings_WhenNoOverridesProvided()
    {
        // Arrange

        // Act
        var settings = MistralInstructChatSettings.Calculate(
            requestSettings: null,
            modelSettings: null,
            providerSettings: null);

        // Assert
        Assert.Equal(MistralInstructChatSettings.Default.StopSequences, settings.StopSequences);
        Assert.Equal(MistralInstructChatSettings.Default.User, settings.User);
        Assert.Equal(MistralInstructChatSettings.Default.UseStreaming, settings.UseStreaming);
        Assert.Equal(MistralInstructChatSettings.Default.Temperature, settings.Temperature);
        Assert.Equal(MistralInstructChatSettings.Default.MaxTokens, settings.MaxTokens);
        Assert.Equal(MistralInstructChatSettings.Default.TopP, settings.TopP);
        Assert.Equal(MistralInstructChatSettings.Default.TopK, settings.TopK);
    }

    // Add more tests to cover overrides at request, model and provider level
}