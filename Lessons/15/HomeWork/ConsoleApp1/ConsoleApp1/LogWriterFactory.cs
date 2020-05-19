using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LogWriterFactory
    {
        public FileLogWriter fileLog = new FileLogWriter();
        public MultipleLogWriter multipleLogWriter = new MultipleLogWriter(logersArg);
        public ConsoleLogWriter consoleLog = new ConsoleLogWriter();

        private static readonly LogWriterFactory _factory = new LogWriterFactory();

        public ILogerWriter GetLogerWriter<T>(object parametrs) where T : ILogerWriter
        {
            return multipleLogWriter(parametrs as ILogerWriter[]);
        }

        private LogWriterFactory(){}

        public static LogWriterFactory GetFactory()
        {
            return _factory;
        }
    }
}
