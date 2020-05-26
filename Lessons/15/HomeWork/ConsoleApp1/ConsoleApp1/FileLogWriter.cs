using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter:AbstractClass
    {
        private string _nameFile = "file.txt";
        public FileLogWriter()
        {
         
        }
        public override void WriteErrorType(string ErrorType)
        {
            File.AppendAllText(_nameFile, ErrorType);
        }
    }
}
