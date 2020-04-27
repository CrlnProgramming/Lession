using System;


namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private int age;
        
        public Person()
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name;}
            set
            { 
                if (value != null)
                {
                    name = value;
                }
            }
        }

      
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value < 100)
                {
                    age = value;
                }
                else
                    throw new ArgumentException("Argument Exception");
            }
        }



        public int agePast => (Age + 4);

        public string Desciption => $"Name: {name},Age: {age},Age past 4 years: {agePast}";

        public void WriteToConsole() => Console.WriteLine(Desciption);
    }

    

}
