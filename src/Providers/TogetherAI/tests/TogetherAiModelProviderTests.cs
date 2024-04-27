using LangChain.Providers.TogetherAi;
using OpenAI.Constants;
using Xunit;

namespace Tests.Providers.TogetherAi;

public class TogetherAiModelProviderTests
{
    // ... existing tests ...
    
    [Fact]
    public void GetModelById_ReturnsExpectedModel_ForUpstageSolarInstructV111BInt4ModelId()
    {
        // Act
        var model = TogetherAiModelProvider.GetModelById(TogetherAiModelIds.UpstageSolarInstructV111BInt4);
        
        // Assert
        Assert.Equal("togethercomputer/SOLAR-10.7B-Instruct-v1.0-int4", model.Id);
        Assert.Equal(4096, model.MaxTokens);
        Assert.Equal(3E-07, model.PricePerInputTokenInUsd);
        Assert.Equal(3E-07, model.PricePerOutputTokenInUsd);
    }
}