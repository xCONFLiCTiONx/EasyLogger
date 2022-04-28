# EasyLogger

.NET Logging for Windows Forms, Console Applications and WPF

[![EasyLogger NuGet Package](https://img.shields.io/nuget/v/xCONFLiCTiONx.Logger.svg)](https://www.nuget.org/packages/xCONFLiCTiONx.Logger/)
[![nuget Downloads](https://img.shields.io/nuget/dt/xCONFLiCTiONx.Logger)](https://www.nuget.org/packages/xCONFLiCTiONx.Logger/)
[![GitHub stars](https://img.shields.io/github/stars/xCONFLiCTiONx/EasyLogger)](https://github.com/xCONFLiCTiONx/EasyLogger/stargazers)

## Donations

Feel free to donate to my [PayPal.Me/xCONFLiCTiONx](https://PayPal.Me/xCONFLiCTiONx) account. I work hard on these projects.

### Latest changes

*You can now backup the log file in x days. Example below...*

### Prerequisites

.NET framework 4

### How to use the Logger

```c#
// Backup immediately
EasyLogger.BackupLogs(EasyLogger.LogFile);

// OR Backup if the log file is older than x days
EasyLogger.BackupLogs(EasyLogger.LogFile, 30);
```

Add a listener to enable logging using the default location.  
The default location is `[SystemDrive]\ProgramData\EasyLogger\[ApplicationName]\[UserName]\[ApplicationName].log`

```c#
// Initiate logging
EasyLogger.AddListener(EasyLogger.LogFile);
```

Log some quick information.

```c#
// Log something
EasyLogger.Info("Log something...");
```

`2020-02-02 14:23:27 [info] Log something...`

### Stop Logging and Set Log Location

Stop the listener and disable logging.

```c#
// Dispose of the logger
EasyLogger.RemoveListener();
```

Set a custom location for the log file.

```c#
// Backup custom log path
var CustomLog = AppDomain.CurrentDomain.BaseDirectory + "LOGGING" + "\\TEST.log";
EasyLogger.BackupLogs(CustomLog);
```

Add a listener to enable logging using a custom location.

```c#
// Initiate logging with a custom log path
EasyLogger.AddListener(CustomLog);
```

Used to log information

```c#
// Log something
EasyLogger.Info("Log something...");
```

`2020-02-02 14:23:27 [info] Log something...`

Used to log warnings

```c#
// Log a warning
EasyLogger.Warning("Don't forget to dispose!");
```

`2020-02-02 14:23:27 [warning] Don't forget to dispose!`

Used to log errors

```c#
// Log an issue
EasyLogger.Error(ex);
```

`2020-02-02 14:23:27 [error] some error such as Object Reference not set to an instance of an Object.`

To disable logging and dispose.

```c#
// Dispose of the logger
EasyLogger.RemoveListener();
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
