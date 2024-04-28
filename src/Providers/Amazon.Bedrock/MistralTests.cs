using LangChain.Providers.Amazon.Bedrock.Predefined.Mistral;
using Moq;
using Xunit;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

public class MistralTests
{
    [Fact]
    public void Mistral7BInstruct_Inherits_MistralModel()
    {
        // Arrange
        var provider = new Mock<BedrockProvider>();

        // Act
        var model = new Mistral7BInstruct(provider.Object);

        // Assert
        Assert.IsType<MistralModel>(model);
    }

    // Add similar tests for other model classes
    // - Mistral8x7BInstruct
    // - MistralLarge
}