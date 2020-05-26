using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LogWriterFactory
    {
        private static LogWriterFactory _instance;
        public static LogWriterFactory Instance => _instance ??= new LogWriterFactory();
        private LogWriterFactory() { }

        public ILogerWriter GetLogerWriter<T>(object parametrs) where T : ILogerWriter
        {
            if (typeof(T) == typeof(ConsoleLogWriter))
            {
                return new ConsoleLogWriter();
            }
            if (typeof(T)==typeof(FileLogWriter))
            {
                return new FileLogWriter();
            }
            if (typeof(T) == typeof(MultipleLogWriter))
            {
                return new MultipleLogWriter(parametrs as ILogerWriter[]);
            }
            else
            {
                throw new Exception("Out of range");
            }
        }
    }
}
