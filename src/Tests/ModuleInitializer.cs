public static class ModuleInit
{
    #region Enable

    [ModuleInitializer]
    public static void Initialize() =>
        VerifyFlurl.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitializeOther() =>
        VerifierSettings.InitializePlugins();
}