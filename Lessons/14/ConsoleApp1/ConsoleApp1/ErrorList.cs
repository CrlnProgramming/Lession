using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ErrorList:IDisposable,IEnumerable<string>
    {
        private readonly string category;

        public string GetCategory()
        {
            return category;
        }

        public List<string> Errors; 

        public ErrorList(string Category,string []item) 
        {
            category = Category;
            Errors = new List<string>(item);
        }

        //public void Add(string e)


        public void Dispose()
        {
            if (Errors != null)
            {
                Errors.Clear();
                Errors = null;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var ge = Errors.GetEnumerator();
            return ge;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
