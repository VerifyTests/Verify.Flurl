static class Extensions
{
    internal static string ReadAsString(this HttpContent content) =>
        content
            .ReadAsStringAsync()
            .GetAwaiter()
            .GetResult();

}