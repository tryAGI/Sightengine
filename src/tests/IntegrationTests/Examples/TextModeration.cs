/*
order: 20
title: Text Moderation
slug: text-moderation

Example showing how to moderate text content for profanity and personal information.
*/

namespace Sightengine.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextModeration()
    {
        using var client = GetAuthenticatedClient();

        //// Moderate text content for profanity, personal information
        //// (emails, phone numbers, usernames, IP addresses, SSNs), and links.
        //// Supports rule-based mode and username validation mode.
        var response = await client.CheckTextAsync(
            text: "Hello world, this is a clean test message.",
            lang: "en",
            mode: CheckTextRequestMode.Rules);

        Assert.AreEqual("success", response.Status);
    }
}
