/*
order: 30
title: AI-Generated Image Detection
slug: ai-detection

Example showing how to detect AI-generated images.
*/

namespace Sightengine.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AiDetection()
    {
        using var client = GetAuthenticatedClient();

        //// Detect whether an image was AI-generated using the genai model.
        //// Works for images from Stable Diffusion, MidJourney, DALL-E,
        //// Adobe Firefly, Flux, and other generators.
        var response = await client.CheckImageByUrlAsync(
            url: "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Image_created_with_a_mobile_phone.png/1200px-Image_created_with_a_mobile_phone.png",
            models: "genai");

        Assert.AreEqual("success", response.Status);
    }
}
