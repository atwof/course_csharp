﻿using System;
using interface_content.Entities;

namespace interface_content.Devices
{
    public class ComboDevice : Device, IScanner, IPrinter 
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing: " + document);
        }

        public string Scan()
        {
            return ("ComboDevice scan result");
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print: " + document);
        }
    }
}

