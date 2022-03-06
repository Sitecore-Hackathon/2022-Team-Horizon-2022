using System;
using System.CommandLine;

namespace Sitecore.DevEx.TeamHorizonTemplates
{
    internal class CommonArgOptions
    {
        public static readonly Option Config = new Option(new string[2]
            {
                "--config",
                "-c"
            }, "Path to root sitecore.json directory (default: cwd)")
        {
            Argument = (Argument)new Argument<string>((Func<string>)(() => Environment.CurrentDirectory))
        };
        public static readonly Option CommandId = new Option(new string[2]
            {
                  "--command-id",
                  "-cid"
            }, "Command ID in Sitecore to be executed")
        {
            Argument = (Argument)new Argument<string>((Func<string>)(() => string.Empty))
        };
        public static readonly Option EnvironmentName = new Option(new string[2]
            {
              "--environment-name",
              "-n"
            }, "Named Sitecore environment to use (default: 'default')")
        {
            Argument = (Argument)new Argument<string>()
        };
        public static readonly Option Verbose = new Option(new string[2]
            {
              "--verbose",
              "-v"
            }, "Write additional diagnostic and performance data.")
        {
            Argument = (Argument)new Argument<bool>((Func<bool>)(() => false))
        };
        public static readonly Option Trace = new Option(new string[2]
            {
              "--trace",
              "-t"
            }, "Write additional diagnostic and performance data.")
        {
            Argument = (Argument)new Argument<bool>((Func<bool>)(() => false))
        };
    }
}
