using System;

namespace ok
{
    abstract class Abstract
    {
        public abstract string AbField1 { get; set; }
        public abstract string AbField2 { get; set; }
        public abstract void Display();
    }

    class newClass : Abstract
    {
        public override string AbField1 { get; set; }
        public override string AbField2 { get; set; }

        public newClass()
        {
            AbField1 = string.Empty;
            AbField2 = string.Empty;
        }
        public newClass(string field1, string field2)
        {
            AbField1 = field1;
            AbField2 = field2;
        }

        public override void Display()
        {
            Console.WriteLine("[ ! ] Display Data [ ! ]");
            Console.WriteLine(AbField1);
            Console.WriteLine(AbField2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            newClass classObject = new newClass("field1data", "field2data");
            classObject.Display();
        }
    }
}