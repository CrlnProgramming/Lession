using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Transport
    {
        public int MaxHeight { get; private set; }
        public int CurrentHeight { get; private set; }

        public Transport(int maxHeight)
        {
            MaxHeight = maxHeight;
            CurrentHeight = 0;
        }

        void TakeUpper(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException;
            }
            if(CurrentHeight+delta>MaxHeight)
            {
                CurrentHeight = MaxHeight;
               
            }
            else
            {
                CurrentHeight = CurrentHeight + delta;
            }
        }

        void TakeLover(int delta)
        {
            if (delta <= 0)
            {
                throw new ArgumentOutOfRangeException;
            }
            if (CurrentHeight - delta < MaxHeight)
            {
                throw new InvalidOperationException("Crash");
            }
            else
            {
                CurrentHeight = CurrentHeight - delta;
            }
        }


        public virtual string WriteToInfo => $"Info about height: {delta}";
    }
}
