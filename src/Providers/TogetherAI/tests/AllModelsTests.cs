using LangChain.Providers.TogetherAi;
using LangChain.Providers.TogetherAi.Predefined;
using Xunit;

namespace Tests.Providers.TogetherAi;

public class AllModelsTests
{
    [Fact]
    public void UpstageSolarInstructV111BInt4Model_Initializes_WithExpectedProviderAndModelId()
    {
        // Arrange
        var provider = new TogetherAiProvider("test_api_key");
        
        // Act
        var model = new UpstageSolarInstructV111BInt4Model(provider);
        
        // Assert
        Assert.Same(provider, model.Provider);
        Assert.Equal(TogetherAiModelIds.UpstageSolarInstructV111BInt4, model.ModelId);
    }
}