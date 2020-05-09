using System;


namespace ConsoleApp1
{
    public class Person
    {
        private string _name;
        private int _age;
        
        public Person()
        {
            Name = _name;
            Age = _age;
        }
        public string Name
        {
            get { return _name;}
            set
            { 
                if (string.IsNullOrWhiteSpace(_name))
                {
                    Console.WriteLine("String is empty");
                }
                    _name = value;
            }
        }

      
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 140)
                {
                    throw new ArgumentException("Argument Exception");
                }
                    _age = value;
            }
        }



        public int agePast => (Age + 4);

        public string Desciption => $"Name: {_name},Age: {_age},Age past 4 years: {agePast}";

        public void WriteToConsole() => Console.WriteLine(Desciption);
    }

    

}
