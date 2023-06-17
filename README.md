# NLog with ILogger and Microsoft SQL server sample

[![Build status](https://ci.appveyor.com/api/projects/status/x6b6mkeirmj8s62u?svg=true)](https://ci.appveyor.com/project/Mahadenamuththa/loggerwithnlogsample)

[![Build history](https://buildstats.info/appveyor/chart/Mahadenamuththa/loggerwithnlogsample)](https://ci.appveyor.com/project/Mahadenamuththa/loggerwithnlogsample/history)

![NLog-in-ASP NET-Core](https://github.com/PasinduUmayanga/LoggerWithNLogSample/assets/21302583/c2448aba-8daf-40df-b22e-4452f9ba782e)



## Features
* ### Easy to configure
NLog is very easy to configure, both through configuration file and programmatically. Even without restarting the application, the configuration can be changed.
* ### Templatable
Every log message can be templated with various layout renders
* ### Extensible
NLog already includes several targets and pre-defined layouts, but you can also extend with your own custom targets and layouts or include own custom context values
* ### Structured logging
Full support for structured logging and handles both message-templates and custom logevent properties.
* ### Microsoft Extension Logging
NLog can be fully integrated with Microsoft Extensible Logging (and ASP.NET Core), without it needing to replace the standard Microsoft LoggerFactory. NLog automatically captures LogEvent properties and can use them in structured logging target output.
* ### appsettings.json
NLog configuration can be loaded from appsettings.json as an alternative to the NLog.config XML file. It is also possible to configure NLog targets using values from appsettings.json with ${configsetting}

## Targets
Targets are used to display, store or pass log messages to another destination. NLog can dynamically write to one of multiple targets for each log message.

There are more than 30 targets provided out-of-the-box, including:

* ### Files
Write logs to any number of files, with automatic file naming and archival.
* ### Event Log
Write to event log local or remote
* ### Database
Store your logs in databases supported by .NET
* ### Console
Write real-time to the command-line console including color coding of messages
* ### E-mail
You can send emails whenever application errors occur
* ### Debugger output
Write to the Debugger Output Window, when debugging the application.
There are also wrapper targets which provide buffering, load balancing, failover situations, asynchronous writing and many more scenarios. The full list of targets is available on the config options page. If you didn't find the target to fit your needs, you can easily write a custom one.

