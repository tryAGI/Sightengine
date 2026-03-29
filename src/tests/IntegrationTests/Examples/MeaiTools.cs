/*
order: 40
title: MEAI Tools
slug: meai-tools

Example showing how to use Sightengine as AI function tools with any IChatClient.
*/

namespace Sightengine.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        using var client = GetAuthenticatedClient();

        //// Sightengine provides AIFunction tools that can be used with any
        //// Microsoft.Extensions.AI IChatClient for content moderation.

        //// Moderate images for harmful content
        var moderateImageTool = client.AsModerateImageTool();
        Assert.IsNotNull(moderateImageTool);

        //// Detect AI-generated images
        var detectAiTool = client.AsDetectAiGeneratedTool();
        Assert.IsNotNull(detectAiTool);

        //// Moderate text for profanity and personal info
        var moderateTextTool = client.AsModerateTextTool();
        Assert.IsNotNull(moderateTextTool);

        //// Validate usernames
        var validateUsernameTool = client.AsValidateUsernameTool();
        Assert.IsNotNull(validateUsernameTool);
    }
}
