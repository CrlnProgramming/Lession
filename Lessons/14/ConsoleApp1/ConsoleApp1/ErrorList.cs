using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ErrorList:IDisposable,IEnumerable<string>
    {
        private readonly string Category;
        private List<string> _errors; 

        public ErrorList(string category,List<string>eror) 
        {
            Category = category;
            _errors = eror;
        }
        public string GetCategory()
        {
            return Category;
        }

        public void Add(string category)
        {
            _errors.Add(category);
        }

        public void Dispose()
        {
            if (_errors != null)
            {
                _errors.Clear();
                _errors = null;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            var ge = _errors.GetEnumerator();
            return ge;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
