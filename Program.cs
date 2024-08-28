using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DesafioPOO.Models;
 // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um Nokia
            Smartphone nokia = new Nokia("123456", "Nokia 3310", "111222333444", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Snake");

            // Instanciando um iPhone
            Smartphone iphone = new Iphone("987654", "iPhone 13", "555666777888", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }