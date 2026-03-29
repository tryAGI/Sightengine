/*
order: 10
title: Image Moderation
slug: image-moderation

Basic example showing how to moderate an image URL for harmful content.
*/

namespace Sightengine.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ImageModeration()
    {
        using var client = GetAuthenticatedClient();

        //// Moderate an image by URL using multiple detection models at once.
        //// Available models include nudity-2.1, gore-2.0, weapon, drugs,
        //// violence, alcohol, offensive, self-harm, scam, face-attributes,
        //// text-content, qr-content, genai, type, and quality.
        var response = await client.CheckImageByUrlAsync(
            url: "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Image_created_with_a_mobile_phone.png/1200px-Image_created_with_a_mobile_phone.png",
            models: "nudity-2.1,violence,offensive");

        Assert.AreEqual("success", response.Status);
    }
}
