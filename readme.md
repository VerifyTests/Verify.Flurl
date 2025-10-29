# <img src="/src/icon.png" height="30px"> Verify.Flurl

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/rfmvbst3od5vpl7p?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-flurl)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Flurl.svg)](https://www.nuget.org/packages/Verify.Flurl/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of [Flurl](https://flurl.dev/) bits.<!-- singleLineInclude: intro. path: /docs/intro.include.md -->

**See [Milestones](../../milestones?state=closed) for release notes.**


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Flurl) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.Flurl/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Flurl)<!-- endInclude -->


## NuGet

 * https://nuget.org/packages/Verify.Flurl


## Usage


### Initialize

Call `VerifyFlurl.Initialize()` in a `[ModuleInitializer]`.

```cs
public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() =>
        VerifyFlurl.Initialize();
}
```

Alternatively, use `VerifierSettings.InitializePlugins()` to initialize all Verify plugins with default settings.

```cs
public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() =>
        VerifierSettings.InitializePlugins();
}
```


### Test

Given any calls to `HttpTest`, those call can be verified as follows:

<!-- snippet: usage -->
<a id='snippet-usage'></a>
```cs
[Fact]
public async Task Usage()
{
    using var httpTest = new HttpTest();

    httpTest.RespondWith("OK");

    await "http://api.mysite.com/".GetAsync();
    await "http://api.mysite.com/".PostAsync(new StringContent("the content"));

    await Verify(httpTest);
}
```
<sup><a href='/src/Tests/Tests.cs#L3-L18' title='Snippet source file'>snippet source</a> | <a href='#snippet-usage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Results in:

<!-- snippet: Tests.Usage.verified.txt -->
<a id='snippet-Tests.Usage.verified.txt'></a>
```txt
[
  {
    Request: http://api.mysite.com/,
    Response: {
      Status: 200 OK,
      Content: {
        Headers: {
          Content-Length: 2,
          Content-Type: text/plain; charset=utf-8
        },
        Value: OK
      }
    }
  },
  {
    Request: {
      Method: POST,
      Uri: http://api.mysite.com/,
      Content: {
        Headers: {
          Content-Length: 11,
          Content-Type: text/plain; charset=utf-8
        },
        Value: the content
      }
    },
    Response: {
      Status: 200 OK,
      Content: {
        Headers: {
          Content-Length: 2,
          Content-Type: text/plain; charset=utf-8
        },
        Value: OK
      }
    }
  }
]
```
<sup><a href='/src/Tests/Tests.Usage.verified.txt#L1-L38' title='Snippet source file'>snippet source</a> | <a href='#snippet-Tests.Usage.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
