using System;
namespace interface_content.Devices
{
    public class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing : " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}

