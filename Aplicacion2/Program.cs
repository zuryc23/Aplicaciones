using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            char op = 's';
            int v1 = 0;
            int v2 = 0;
            int total = 0;
            bool estado = true;

            while (op=='s')
            {
                Console.Clear();
                Console.WriteLine("1.Suma"); 
                Console.WriteLine("2.Resta"); 
                Console.WriteLine("3.Multiplicacion"); 
                Console.WriteLine("4.Division"); 
                Console.WriteLine("5.Salir");

                if (menu == 1)
                {
                    Console.WriteLine("suma");

                    while (estado)
                    {
                        Console.WriteLine("Ingrese el primer valor: ");
                        v1 = int.Parse(Console.ReadLine());

                        try
                        {
                            v1 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;
                    total = v1 + v2;
                    Console.Write("El valor es: " + total);

                }   

                else if(menu == 2)
                {
                    Console.WriteLine("Resta");

                    while(estado)
                    {
                        Console.WriteLine("Ingrese el primer valor: ");

                        try
                        {
                            v1 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;
                    while(estado)
                    {
                        Console.WriteLine("Ingrese el segundo valor: ");

                        try
                        {
                            v2 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;
                    total = v1 - v2;
                    Console.Write("El valor es: " + total);
                }

                else if(menu==3)
                {
                    Console.WriteLine("Multiplicación");

                    while(estado)
                    {
                        Console.WriteLine("Ingrese el primer valor: ");

                        try
                        {
                            v1 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;

                    while(estado)
                    {
                        Console.WriteLine("Ingrese el segundo valor: ");

                        try
                        {
                            v2 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ: ");
                        }
                    }

                    estado = true;
                    total = v1 * v2;
                    Console.Write("El valor es: " + total);
                }

                else if(estado)
                {
                    Console.WriteLine("División");

                    while(estado)
                    {
                        Console.WriteLine("Ingrese el primer valor: ");

                        try
                        {
                            v1 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;

                    while(estado)
                    {
                        Console.WriteLine("Ingrese el segundo valor: ");

                        try
                        {
                            v2 = int.Parse(Console.ReadLine());
                            estado = false;
                        }

                        catch
                        {
                            Console.WriteLine("ERROR EL DATO NO SE PROCESARÁ.");
                        }
                    }

                    estado = true;
                    total = v1 / v2;
                    Console.Write("El valor es: " + total);
                }

                else
                {
                    op = 'n';
                }

                Console.ReadKey();
                  
            }
        }
    
    }
}

