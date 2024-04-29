using NUnit.Framework;

namespace LangChain.Providers.Tests;

[TestFixture]
public class OllamaEmbeddingModelTests
{
    [Test]
    public async Task CreateEmbeddingsAsync_ShouldReturnEmbeddings()
    {
        var provider = Substitute.For<OllamaProvider>();
        var model = new OllamaEmbeddingModel(provider);

        var request = new EmbeddingRequest
        {
            Strings = new[] { "test" }
        };

        var response = await model.CreateEmbeddingsAsync(request);
        
        Assert.That(response.Values, Has.Length.EqualTo(1));
        Assert.That(response.Dimensions, Is.GreaterThan(0));
        Assert.That(response.UsedSettings, Is.EqualTo(EmbeddingSettings.Default));
    }

    [Test]
    public void CreateEmbeddingsAsync_ShouldThrowWhenRequestNull()
    {
        var provider = Substitute.For<OllamaProvider>();
        var model = new OllamaEmbeddingModel(provider);

        Assert.ThrowsAsync<ArgumentNullException>(async () => 
            await model.CreateEmbeddingsAsync(null!));
    }
}