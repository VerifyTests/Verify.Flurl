# <img src="/src/icon.png" height="30px"> Verify.Flurl

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/75umulyw3wt0rb6e?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-flurl)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Flurl.svg)](https://www.nuget.org/packages/Verify.Flurl/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of Http bits.


## NuGet package

https://nuget.org/packages/Verify.Flurl/


## Enable

Enable VerifyFlurl once at assembly load time:

<!-- snippet: Enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Initialize() =>
    VerifyFlurl.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Spider](https://thenounproject.com/term/spider/904683/) designed by [marialuisa iborra](https://thenounproject.com/marialuisa.iborra/) from [The Noun Project](https://thenounproject.com).
