using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;


namespace ConsoleAppEvents
{
    class FileWriterWithProgress 
    {
        public delegate void WritingPerfomed(int bytesDone, int totalBates);
        public event EventHandler WritingCompleted;
        public event WritingPerfomed WritingPerfoming;

        public byte[] WriteBytes(int dataSize, float percentageToFireEvent)
        {
            var random = new Random();
            var data = new byte[dataSize];
            for(var i = 0; i < data.Length; i++)
            {
                data[i] = (byte)random.Next(256);
                
                if ((i+1) % percentageToFireEvent == 0)
                {
                    WritingPerfoming(i + 1, data.Length);
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
            WritingCompleted(this, EventArgs.Empty);

            return data;
        }
        public void OnRandomDate(int bytesDone, int totalBates)
        {
            WritingPerfoming?.Invoke(bytesDone, totalBates);
        }

        public void OnRandomDataEnd(object sender, EventArgs e)
        {
            WritingCompleted?.Invoke(sender, e);
        }

    }
}
