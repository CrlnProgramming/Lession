using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void RandomDateGeneratedHandler(int bytes, int totalBytes);
    class RandomDateGenerator
    {
        public event RandomDateGeneratedHandler RandomDateGenerating;
        public event EventHandler RanomDateGenerated;

        public byte[] GetRandom(int datesize, int bytesDoneToRaiseEvent)
        {
            var result = new byte[datesize];
            var rand = new Random();

            for (int i = 0; i < datesize; i++)
            {
                result[i] = (byte)rand.Next(256);

                if ((i + 1) % bytesDoneToRaiseEvent == 0)
                {
                    
                }
            
            }



            return result;
        } 
    }
}
