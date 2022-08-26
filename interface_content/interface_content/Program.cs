using System;
using interface_content.Enums;
using interface_content.Entities;
using interface_content;

// Forma sem interface
//solucao_sem_interface solucao = new solucao_sem_interface();
//solucao.SolucaoErrada();

// Shape sem interface
IShape shape = new Circle() { Radius = 2.0, Color = Color.White };
IShape shape1 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

Console.WriteLine(shape);
Console.WriteLine(shape1);