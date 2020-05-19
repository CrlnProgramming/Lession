using System;


namespace ConsoleApp1
{
    public class Acaount<T>
    {
        public T Id { get; private set; }
        public string Name { get; private set; }

        public Acaount(T id, string name)
        {
            Id = id;
            Name = name;
        }

        public void WriteProporties() => Console.WriteLine($"id: {Id}, name: {Name}");
    }

}

