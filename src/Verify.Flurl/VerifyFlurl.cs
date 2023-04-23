namespace VerifyTests;

public static class VerifyFlurl
{
    public static bool Initialized { get; private set; }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        VerifierSettings
            .AddExtraSettings(serializer =>
            {
                var converters = serializer.Converters;
                converters.Add(new HttpMethodConverter());
            });
    }
}