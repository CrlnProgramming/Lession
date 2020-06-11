using System;
using System.IO;
using System.Threading;

namespace ConsoleAppEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
           const string binaryFileName = "file.txt";
           var generator = new FileWriterWithProgress();
            //generator.WriteBytes += OnRandomDate;


            //File.WriteAllBytes(binaryFileName, RandomBytes);
            if (File.Exists(binaryFileName))
            {
                File.Delete(binaryFileName);
            }
        }
        private static void OnRandomDate(int bytesDone, int totalBytes)
        {
            Console.WriteLine($"Generated {bytesDone} from {totalBytes} byte(s)...");
        }

        private static void OnRandomDataEnd(object sender, EventArgs e)
        {
            Console.WriteLine($"Generation DONE");
        }

        private static void DrowingDonwlodeIcon(byte[] data)
        {
            Console.WriteLine("[{0}]", new String(' ', data.Length));

            Console.SetCursorPosition(0, Console.CursorTop - 1);
            for (int process = 0; process < data.Length; process++)
            {
                Console.SetCursorPosition(process + 1, Console.CursorTop);
                Console.Write("|");

                Console.SetCursorPosition(data.Length + 3, Console.CursorTop);
                Console.Write("{0}% ", process * data.Length);
                Thread.Sleep(500);
                Console.ResetColor();
            }
        }
    }
}
