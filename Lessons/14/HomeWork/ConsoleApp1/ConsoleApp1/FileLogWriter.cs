using System;
using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter : AbstractClass
    {
        private static readonly Lazy<FileLogWriter> _intance = new Lazy<FileLogWriter>(() => new FileLogWriter());
        private string _nameFile = "file.txt";

        private FileLogWriter()
        {
            
        }

        
        public static FileLogWriter Intance
        {
            get { return _intance.Value; }
        }

        public override void WriteErrorType(string ErrorType)
        {
            File.AppendAllText(_nameFile, ErrorType);
        }
    }
}
