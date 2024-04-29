using NUnit.Framework;
using LangChain.Providers.OpenRouter.Predefined;

namespace LangChain.Providers.OpenRouter.Tests;

[TestFixture]
public class AnthropicClaudeV21ModelTests
{
    [Test]
    public void Constructor_SetsModelId()
    {
        var provider = new OpenRouterProvider("api_key");
        var model = new AnthropicClaudeV21Model(provider);
        
        Assert.That(model.ModelId, Is.EqualTo(OpenRouterModelIds.AnthropicClaudeV21));
    }
}