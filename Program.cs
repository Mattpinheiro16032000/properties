﻿using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
             

            Console.WriteLine(p.Nome);

            p.Nome = "T";    // alterar

            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco);

            Console.WriteLine(p.Quantidade);

            
            

        }
    }
}