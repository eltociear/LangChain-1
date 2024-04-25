using Anthropic.SDK.Messaging;
using LangChain.Providers.Anthropic.Extensions;
using Xunit;

namespace LangChain.Providers.Anthropic.Tests;

public class StringExtensionsTests
{
    [Fact]  
    public void AsHumanMessage_WrapsContentInTextContent()
    {
        // Arrange
        var content = "test content";

        // Act
        var result = content.AsHumanMessage();

        // Assert 
        Assert.Equal(RoleType.User, result.Role);
        Assert.Single(result.Content);
        Assert.Equal("test content", ((TextContent)result.Content[0]).Text);
    }

    // Add similar test for AsAssistantMessage
}