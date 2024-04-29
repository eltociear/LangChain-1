using NUnit.Framework;

namespace LangChain.Providers.Tests;

[TestFixture]
public class LLamaSharpEmbeddingsTests
{
    [Test]
    public async Task CreateEmbeddingsAsync_ShouldReturnEmbeddings()
    {
        var model = LLamaSharpEmbeddings.FromPath("path");

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
        var model = LLamaSharpEmbeddings.FromPath("path");

        Assert.ThrowsAsync<ArgumentNullException>(async () => 
            await model.CreateEmbeddingsAsync(null!));
    }
}