using Anthropic.SDK.Constants;
using LangChain.Providers.Anthropic;
using Xunit;

namespace LangChain.Providers.Anthropic.Tests;

public class ApiHelpersTests
{
    [Theory]
    [InlineData(AnthropicModels.Claude_v2_0, 100, 200, 0.0024)]  
    [InlineData(AnthropicModels.Claude_v2_1, 100, 200, 0.0024)]
    [InlineData(AnthropicModels.Claude3Haiku, 100, 200, 0.000225)]
    [InlineData(AnthropicModels.Claude3Sonnet, 100, 200, 0.0008)]
    [InlineData(AnthropicModels.Claude3Opus, 100, 200, 0.0158)]
    [InlineData(AnthropicModels.ClaudeInstant_v1_2, 100, 200, 0.000751)]
    public void CalculatePriceInUsd_ReturnsExpectedPrice(
        string modelId, 
        int promptTokens,
        int completionTokens,
        double expectedPrice)
    {
        // Act
        var result = ApiHelpers.CalculatePriceInUsd(modelId, completionTokens, promptTokens);

        // Assert
        Assert.Equal(expectedPrice, result);
    }

    [Theory]
    [InlineData(AnthropicModels.Claude_v2_0, 100000)]
    [InlineData(AnthropicModels.ClaudeInstant_v1_2, 100000)]  
    [InlineData(AnthropicModels.Claude_v2_1, 200000)]
    [InlineData(AnthropicModels.Claude3Haiku, 200000)]
    [InlineData(AnthropicModels.Claude3Sonnet, 200000)]
    [InlineData(AnthropicModels.Claude3Opus, 200000)]
    public void CalculateContextLength_ReturnsExpectedLength(string modelId, int expectedLength)
    {
        // Act
        var result = ApiHelpers.CalculateContextLength(modelId);

        // Assert
        Assert.Equal(expectedLength, result);  
    }
}