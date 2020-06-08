using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gentrator 
    {
        public event EventHandler<DateGeneratorEventArgs> DataGeneratedEvArgsArray;
        public delegate void RandomDateGeneratedHendler(int bytesDone);

        public void RandomDateGenerator (int dateSize)
        {
            Random random = new Random();
            Byte[] b = new byte[dateSize];
            random.NextBytes(b);
            if (b != null)
            {
                DataGeneratedEvArgsArray(this, new DateGeneratorEventArgs(b));
            }
        }
    }

    class DateGeneratorEventArgs
    {
        public byte[] array { get; }

        public DateGeneratorEventArgs(byte[] Array)
        {
            array = Array;
        }
    }

}
