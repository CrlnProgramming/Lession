using System;
using System.ComponentModel;
using System.IO;

namespace ConsoleAppEvents
{
    public class FileWriterWithProgress
    {
        public delegate void WritingPerfomed(int bytesDone, int totalBates);

        public event WritingPerfomed RandomDataGenterating;
        public event EventHandler<DataStorage> WritingCompleted;
        public byte[] WriteBytes(byte[] data, float percentageToFireEvent)
        {
            var random = new Random();
            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (byte)random.Next(256);
                if((i+1)%percentageToFireEvent == 0)
                {
                    RandomDataGenterating(i + 1, data.Length);
                }
            }
            //Console.WriteLine("Random data bytes: {0}", Convert.ToBase64String(RandomBytes));
            return data;
        }
        protected virtual void OnRandomDate(int bytesDone, int totalBytes)
        {
            RandomDataGenterating?.Invoke(bytesDone, totalBytes);
        }

        protected virtual void OnGeneratedCompleted(object sender,byte [] RanomArray)
        {
            var args = new DataStorage
            {
                storageData = RanomArray
            };
            WritingCompleted?.Invoke(sender, args);
        }
        
    }
}
    
