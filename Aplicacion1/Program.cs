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
            string[,] dato= new string [5,15];
            char OP ='s';
            int op;


            while(OP =='s')
            { 
                dato(0,0)= 'Nombre';
                dato(1,0)= 'apellido';
                dato(2,0)= 'Dirección';
                dato(3,0)= 'Telefono';
                dato(4,0)= 'Correo Electrónico';

                Console.WriteLine("Que desea realizar? : \nno.1 Ingresar Contacto \nno.2 Mostrar Contacto \nno.3 Buscar");
                op = int.Parse(ConsoleReadLine());


                if (op==1)
                {
                  Console.Clear();
                  Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Dirección, Télefono, Correo Electrónico \n");

                  for (int f=1; f<15; f++)
                  {
                    for (int c=0; c<5; c++ )
                    {
                      Console.Write("Ingrese Nota (Valor" +(f) + ", Dato: " + (c+1) + "):" );
                      dato (c,f)= Console.ReadLine();
                    }
                  }
                }

                if (op==2)
                {
                  Console.Clear();
                  Console.WriteLine("\n Datos  de contactos: ");

                  for (int f=0; f<15; f++)
                  {
                    Console.WriteLine(dato(0,f) + " " + dato (1,f) + " " + dato(2,f) + " " + dato (3,f) + " " + dato (4,f));
                  }
                }

                if (op==3)
                {
                  Console.Clear();
                  Console.WriteLine("Elija el número de contacto que desea encontrar: \n");
                  
                    int j;
                    j=int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Contacto que buscaba: " + dato(0,a) + " " + dato(1,a) + " " + dato(2,a) +
                        " " + dato(3,a) + " " + dato(4,a))
                }

                Console.ReadKey();

            }

            
           
    }   }
}
