using LangChain.Providers.Amazon.Bedrock.Predefined.Meta;
using Moq;
using Xunit;

namespace LangChain.Providers.Amazon.Bedrock.Tests;

public class MetaTests
{
    [Fact]
    public void Llama2With13BModel_Inherits_MetaLlamaChatModel()
    {
        // Arrange
        var provider = new Mock<BedrockProvider>();

        // Act
        var model = new Llama2With13BModel(provider.Object);

        // Assert
        Assert.IsType<MetaLlamaChatModel>(model);
    }

    // Add similar tests for other model classes
    // - Llama2With70BModel
    // - Llama2WithChat13BModel
    // - Llama2WithChat70BModel
    // - Llama3With8BInstructBModel
    // - Llama3With70BInstructBModel
}