using NUnit.Framework;

namespace LangChain.Providers.Tests;

[TestFixture]
public class EmbeddingResponseTests
{
    [Test]
    public void Dimensions_ShouldMatchValuesLength()
    {
        var response = new EmbeddingResponse 
        {
            Values = new[] { new float[] { 1, 2, 3 } },
            UsedSettings = EmbeddingSettings.Default
        };

        Assert.That(response.Dimensions, Is.EqualTo(3));
    }

    [Test]
    public void Dimensions_ShouldBeZeroWhenValuesEmpty()
    {
        var response = new EmbeddingResponse
        {
            Values = Array.Empty<float[]>(),
            UsedSettings = EmbeddingSettings.Default  
        };

        Assert.That(response.Dimensions, Is.EqualTo(0));
    }

    [Test]
    public void Dimensions_ShouldBeZeroWhenValuesNull()
    {
        var response = new EmbeddingResponse
        {
            Values = null!,
            UsedSettings = EmbeddingSettings.Default
        };

        Assert.That(response.Dimensions, Is.EqualTo(0));
    }
}