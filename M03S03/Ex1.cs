using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


        public static void Main(string[] args)
        {
            Console.WriteLine ("Valor percentual: " + processo(120,20));
        }
    
        public static double processo(double x, double y)
        {
            double resultado = 0;
            resultado = x * (y/100);
            return resultado;
        }
