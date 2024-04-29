using NUnit.Framework;
using OpenAI.Constants;

namespace LangChain.Providers.OpenRouter.Tests;

[TestFixture]
public class OpenRouterModelProviderTests
{
    [Test]
    public void GetModelById_AnthropicClaudeV21_ReturnsModel()
    {
        var model = OpenRouterModelProvider.GetModelById(OpenRouterModelIds.AnthropicClaudeV21);
        
        Assert.That(model, Is.Not.Null);
        Assert.That(model.Id, Is.EqualTo("anthropic/claude-2.1"));
        Assert.That(model.MaxTokens, Is.EqualTo(200000));
        Assert.That(model.PricePerInputTokenInUsd, Is.EqualTo(8E-06));  
        Assert.That(model.PricePerOutputTokenInUsd, Is.EqualTo(2.4E-05));
    }
    
    [Test]
    public void GetModelById_AnthropicClaudeV21SelfModerated_ReturnsModel()
    {
        var model = OpenRouterModelProvider.GetModelById(OpenRouterModelIds.AnthropicClaudeV21SelfModerated);
        
        Assert.That(model, Is.Not.Null);
        Assert.That(model.Id, Is.EqualTo("anthropic/claude-2.1:beta"));
        Assert.That(model.MaxTokens, Is.EqualTo(200000));
        Assert.That(model.PricePerInputTokenInUsd, Is.EqualTo(8E-06));
        Assert.That(model.PricePerOutputTokenInUsd, Is.EqualTo(2.4E-05));
    }
}