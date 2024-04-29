using NUnit.Framework;

namespace LangChain.Providers.OpenRouter.Tests;

[TestFixture]
public class OpenRouterModelIdsTests
{
    [Test]
    public void AnthropicClaudeV21_Exists()
    {
        Assert.That(Enum.IsDefined(typeof(OpenRouterModelIds), OpenRouterModelIds.AnthropicClaudeV21));
    }
    
    [Test]  
    public void AnthropicClaudeV21SelfModerated_Exists()
    {
        Assert.That(Enum.IsDefined(typeof(OpenRouterModelIds), OpenRouterModelIds.AnthropicClaudeV21SelfModerated));
    }
}