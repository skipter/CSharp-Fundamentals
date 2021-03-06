﻿namespace _01.Logger.Appenders
{
    using Layouts.Contracts;
    using Contracts;

    using System.IO;
    using _01.Logger.Loggers;
    using _01.Logger.Loggers.Enums;

    public class FileAppender : Appender
    {
        private const string path = "log.txt";

        private readonly ILogFile logFile;

        public FileAppender(ILayouts layout, ILogFile logFile)
            :base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + "\n";
                this.logFile.Write(content);
                File.AppendAllText(path, content);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}," +
                $" File size: {this.logFile.Size}";
        }
    }
}
