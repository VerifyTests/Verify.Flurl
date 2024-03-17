public static class ModuleInit
{
    [ModuleInitializer]
    public static void Initialize() =>
        VerifierSettings.InitializePlugins();
}