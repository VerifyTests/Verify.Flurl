using Flurl.Http.Testing;

[UsesVerify]
public class Tests
{
    [Fact]
    public async Task Usage()
    {
        #region Usage

        using var httpTest = new HttpTest();
        httpTest.RespondWith("OK");

        await MethodThatDoesHttpCall();

        httpTest.ShouldHaveCalled("https://api.com/*")
            .WithVerb(HttpMethod.Post)
            .WithContentType("application/json");

        #endregion
    }

    static async Task MethodThatDoesHttpCall()
    {
        var value = await "https://api.com"
            .AppendPathSegment("person")
            .SetQueryParams(new {a = 1, b = 2})
            .WithOAuthBearerToken("my_oauth_token")
            .PostJsonAsync(new
            {
                first_name = "Claire",
                last_name = "Underwood"
            })
            .ReceiveString();
    }
}