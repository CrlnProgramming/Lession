using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BaseDocument
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTimeOffset IssueDate { get; set; }

        public virtual string Decription => $"BaseDocument have: {Title} , {Number},{IssueDate}";

       public BaseDocument(string number,string title)
        {
            Number = number;
            Title = title;
        }

        public void WriteToConsel()
        {
            Console.WriteLine(Decription);
        }
    }



     class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

        public Passport(string number ):base (number, "Passport")
        {

        }
        

        public override string Decription => $"BaseDocument have: {Title} ," +
            $"number: {Number},IssueDate:{IssueDate}.\n {PersonName}lives in country:{Country}";
        
        
        


        //public new void WriteToConsel()
        //{
          //  Console.WriteLine(Decription);
        //}

    }
}
