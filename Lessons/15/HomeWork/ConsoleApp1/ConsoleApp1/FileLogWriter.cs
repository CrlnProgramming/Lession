using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter:AbstractClass
    {
        private string _nameFile;
        public FileLogWriter()
        {
            _nameFile = "file.txt";
        }
        public override void WriteErrorType(string ErrorType)
        {
            File.AppendAllText(_nameFile, ErrorType);
        }
    }
}
