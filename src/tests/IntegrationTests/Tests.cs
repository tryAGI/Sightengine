namespace Sightengine.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SightengineClient GetAuthenticatedClient()
    {
        var apiUser =
            Environment.GetEnvironmentVariable("SIGHTENGINE_API_USER") is { Length: > 0 } userValue
                ? userValue
                : throw new AssertInconclusiveException("SIGHTENGINE_API_USER environment variable is not found.");

        var apiSecret =
            Environment.GetEnvironmentVariable("SIGHTENGINE_API_SECRET") is { Length: > 0 } secretValue
                ? secretValue
                : throw new AssertInconclusiveException("SIGHTENGINE_API_SECRET environment variable is not found.");

        var client = new SightengineClient(apiUser, apiSecret);

        return client;
    }
}
