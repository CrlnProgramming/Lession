using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class ClassGen
    {
        public event EventHandler<DataGanerateEventArgs> GetArray;
        public void Rand(int count)
        {
            
            Random rand = new Random();
            Byte[] b = new Byte[count];

            rand.NextBytes(b);
            if(b! = null)
            {
                GetArray(this, new DataGanerateEventArgs(b));
            }
            
        }

        
        public event EventHandler<byte[]> GetArray;
    }

    class DataGanerateEventArgs
    {
        public byte[] array{ get; }
        public DataGanerateEventArgs(byte[] Array)
        {
            array = Array;
        }
    }
