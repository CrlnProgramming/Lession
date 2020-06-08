using System;
using System.IO;

namespace ConsoleAppEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string binaryFileName = "file.txt";
            var generator = new FileWriterWithProgress();
            generator.WritingCompleted += OnRandomDataEnd; 
            generator.WritingPerfoming += OnRandomDate;
            var RandomBytes = generator.WriteBytes(10, 5);

            Console.WriteLine("Random data bytes: {0}", Convert.ToBase64String(RandomBytes));

            File.WriteAllBytes(binaryFileName, RandomBytes);
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

    }
}
