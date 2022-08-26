using System;
using interface_content.Enums;
using interface_content.Entities;
using interface_content.Devices;
using interface_content;

/* Forma sem interface
solucao_sem_interface solucao = new solucao_sem_interface();
solucao.SolucaoErrada();

// Shape sem interface
IShape shape = new Circle() { Radius = 2.0, Color = Color.White };
IShape shape1 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

Console.WriteLine(shape);
Console.WriteLine(shape1);
*/

Printer printer = new Printer() { SerialNumber = 1999 };
printer.ProcessDoc("My letter");
printer.Print("My letter");

Scanner scanner = new Scanner() { SerialNumber = 2000 };
scanner.ProcessDoc("My email");
Console.WriteLine(scanner.Scan());