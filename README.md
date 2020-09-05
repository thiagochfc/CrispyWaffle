# CrispyWaffle

The CrispyWaffle project - a toolkit for .NET (Core & Framework) projects. 

[![GitHub license](https://img.shields.io/github/license/guibranco/CrispyWaffle)](https://github.com/guibranco/CrispyWaffle)
[![Time tracker](https://wakatime.com/badge/github/guibranco/CrispyWaffle.svg)](https://wakatime.com/badge/github/guibranco/CrispyWaffle)

![Crispy Waffle logo](https://raw.githubusercontent.com/guibranco/CrispyWaffle/master/logo.png)


## CI/CD

| Branch | Build status | Last commit |
|--------|--------------|-------------|
| Master | [![Build status](https://ci.appveyor.com/api/projects/status/dr93gad0na076ng3/branch/master?svg=true)](https://ci.appveyor.com/project/guibranco/crispywaffle/branch/master) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/CrispyWaffle/master)](https://github.com/guibranco/CrispyWaffle) |
| Develop | [![Build status](https://ci.appveyor.com/api/projects/status/dr93gad0na076ng3/branch/develop?svg=true)](https://ci.appveyor.com/project/guibranco/crispywaffle/branch/develop) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/CrispyWaffle/develop)](https://github.com/guibranco/CrispyWaffle) |

## Code Quality

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/f9e814c726bb4ccb8b0380b1fd882f4b)](https://www.codacy.com/manual/guilherme_9/CrispyWaffle?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/CrispyWaffle&amp;utm_campaign=Badge_Grade)
[![codecov](https://codecov.io/gh/guibranco/CrispyWaffle/branch/master/graph/badge.svg)](https://codecov.io/gh/guibranco/CrispyWaffle)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=coverage)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)

[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=code_smells)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_CrispyWaffle&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_CrispyWaffle)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/CrispyWaffle.svg?style=flat)](https://github.com/guibranco/CrispyWaffle) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/CrispyWaffle/total.svg?style=flat)](https://github.com/guibranco/CrispyWaffle)

Download the latest zip file from the [Release](https://github.com/GuiBranco/CrispyWaffle/releases) pages.

### Nuget package manager

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **CrispyWaffle** | [![CrispyWaffle NuGet Version](https://img.shields.io/nuget/v/CrispyWaffle.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle/) | [![CrispyWaffle NuGet Downloads](https://img.shields.io/nuget/dt/CrispyWaffle.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle/) |
| **CrispyWaffle.Configuration** | [![CrispyWaffle Configuration NuGet Version](https://img.shields.io/nuget/v/CrispyWaffle.Configuration.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Configuration/) | [![CrispyWaffle Configuration NuGet Downloads](https://img.shields.io/nuget/dt/CrispyWaffle.Configuration.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Configuration/) |
| **CrispyWaffle.Elmah** | [![CrispyWaffle ELMAH NuGet Version](https://img.shields.io/nuget/v/CrispyWaffle.Elmah.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Elmah/) | [![CrispyWaffle ELMAH NuGet Downloads](https://img.shields.io/nuget/dt/CrispyWaffle.Elmah.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Elmah/) |
| **CrispyWaffle.Log4Net** | [![CrispyWaffle Log4Net NuGet Version](https://img.shields.io/nuget/v/CrispyWaffle.Log4Net.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Log4Net/) | [![CrispyWaffle Log4Net NuGet Downloads](https://img.shields.io/nuget/dt/CrispyWaffle.Log4Net.svg?style=flat)](https://www.nuget.org/packages/CrispyWaffle.Log4Net/) |


### Nuget package maanger via *Package Manager Console*:

**Core**
```ps
Install-Package CrispyWaffle
```

**Configuration**
```ps
Install-Package CrispyWaffle.Configuration
```

**ELMAH**
```ps
Install-Package CrispyWaffle.Elmah
```

**Log4Net**
```ps
Install-Package CrispyWaffle.Log4Net
```

---

## Usage

### Logging

A simple `console application` with simple logging example:

```cs

static void Main(string[] args)
{
    ServiceLocator.Register<IConsoleLogAdapter, StandardConsoleLogAdapter>(LifeStyle.SINGLETON);
    ServiceLocator.Register<IExceptionHandler, NullExceptionHandler>(LifeStyle.SINGLETON);
        
    LogConsumer.AddProvider<ConsoleLogProvider>();
        
    LogConsumer.Info("Hello world Crispy Waffle");
        
    LogConsumer.Debug("Current time: {0:hh:mm:ss}", DateTime.Now);
        
    LogConsumer.Warning("Press any key to close the program!");
    Console.ReadKey();
}
```

### Events

An example using `Events`\`EventsHandlers` 

```cs

//The event class.
public class SomeEvent : IEvent 
{
    public SomeEvent(string data)
    {
        Id = Guid.NewGuid();
        Date = DateTime.Now;
        Data = data;
    }

    public Guid Id { get; }

    public string Data { get; }

    public DateTime Date { get; }
}

//The event handler class. Each event can be handled by N event handlers.
public class SomeEventHandler : IEventHandler<SomeEvent>
{
    //constructor of the class, with dependencies...

    public void Handle(SomeEvent args)
    {
        LogConsumer.Warning("Event 'SomeEvent' handled by 'SomeEventHandler'. Event Id: {0}", args.Id);
        //do any other processing stuff...
    }

}

public class AnotherSomeEventHandler : IEventHandler<SomeEvent>
{
    //constructor of the class, with dependencies...

    public void Handle(SomeEvent args)
    {
        LogConsumer.Warning("Event 'SomeEvent' handled by 'AnotherSomeEventHandler'. Event Id: {0}", args.Id);
            
        //someOtherDependency.DoSomeStuffWithEvent(args.Id, args.Data);
        //do any other processing stuff...
    }
}

// Program entry point
public static class Program 
{    
    public static void Main(string[] args)
    {
        //Initialize the dependencies with ServiceLocator.
        //Initialize log providers/adapters
        //...

        var evt = new SomeEvent ("README.md test data");
        EventsConsumer.Raise(evt);
    }
}
```

### Scheduled jobs (using CRON expressions)

Using `cron` expression to schedule tasks/jobs inside a program.

```cs
public static class Program
{
    public static void Main(string[] args)
    {
        var exampleObj = new SomeClass();
        exampleObj.Counter = 10;

        var jobManager = new JobManager();
        jobManager.AddJob(new JobRunner("* * * * *", () => { exampleObj.Counter++; }));
        jobManager.Start();

        Thread.Sleep(120 * 1000); //waits 2 minutes

        jobManager.Stop(); //stops the manager, so no more execution runs.

        if(exampleObj.Counter == 2)
        {
            LogConsumer.Warning("Example job runned for 2 times!");
        }

    }

    internal class SomeClass 
    {
        public int Counter { get; set; } 
    }

}

```

---

## Changelog

2020-09-05 - Version 2.2 - [@guibranco](https://github.com/guibranco)

- Add scheduler feature.

2020-09-04 - Version 2.1 - [@guibranco](https://github.com/guibranco)

- Add the Configuration project and package.
- Add Mustache template engine (inspired by Mustache/Handlebars).
- Add Resource template repository.
- Add Elmah & Log4Net projects (logging).
- Basic usage examples.

2020-08-03 - Version 2.0 - [@guibranco](https://github.com/guibranco)

- Removed some application specific patterns from *StringExtensions* class

2020-07-24 - Version 1.3 - [@guibranco](https://github.com/guibranco)

- Add EvenLogProvider and EventLogAdapter.
- Add log Trace methods that support exceptions.
- Add Fatal log level.

2020-03-28 - Version 1.2 - [@guibranco](https://github.com/guibranco)

- Add some unit tests.
- Update appveyor.yml with build enhancements and test coverages.
- Update readme template.

2019-09-27 - Version 1.1 - [@guibranco](https://github.com/guibranco)

- Add Math Extensions (CrispyWaffle.Extensions.MathExtensions namespace).
- Add Personal Data Validations (CrispyWaffle.Validations.PersonalDataValidations).
- Rename method *FormatDocument* to *FormatBrazilianDocument* (CrispyWaffle.Extensions.ConversionExtensions).
- Rename method *ParsePhoneNumber* to *arseBrazilianPhoneNumber* (CrispyWaffle.Extensions.ConversionExtensions).
- Removed *CleanListItems* (CrispyWaffle.Extensions.ConversionExtensions).
- Rename method *TryParsePhoneNumber* to *TryParseBrazilianPhoneNumber* (CrispyWaffle.Extensions.ConversionExtensions).
- Removed *CleanListItems* and *ToListString* (CrispyWaffle.Extensions.ConversionExtensions) **(Specific to application patterns)**.

---
