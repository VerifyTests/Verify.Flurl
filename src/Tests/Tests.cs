public class Tests
{
    #region usage

    [Fact]
    public async Task Usage()
    {
        using var httpTest = new HttpTest();

        httpTest.RespondWith("OK");

        await "http://api.mysite.com/".GetAsync();
        await "http://api.mysite.com/".PostAsync(new StringContent("the content") );

        await Verify(httpTest);
    }

    #endregion
}