using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[3];
            char buscar;
            string Op = "si";
            int op;
            
            while(Op=="si")
            {
                Console.Clear();
                Console.WriteLine("agenda");
                Console.WriteLine("\nno.1 Ingresar Contacto \nno.2 Mostrar Contactos \nno.3 Buscar Contacto: ");

                op = int.Parse(Console.ReadLine());

            }
            string[,] vec = new string[5, 15];

            for(int f=0; f<15; f++)
            {
                for(int c=0; c<5; c++)
                {
                    Console.Write("");
                    vec[c, f] = Console.ReadLine();
                }
            }
        }
    }
}
