﻿using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args) {

            double pi, raio, volume;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = (4.0/3)*pi*(Math.Pow(raio,3));
            Console.WriteLine($"VOLUME = {volume.ToString("0.000")}");
        }
    }
}
