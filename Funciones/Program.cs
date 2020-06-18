using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funciones
{
    class Program
    {
        static string[,] agenda;

        static int Contactos = 0;

        static int Contador = 0;


        static void Main(string[] args)

        {


            Contactos = PedirNoContactos();//10 

            agenda = new string[4, Contactos];

            Console.WriteLine("\n");

            GuardarContacto();

            GuardarContacto();

            MostrarContactos();



            BuscarModificarEliminar('b');

            BuscarModificarEliminar('m');

            MostrarContactos();

            BuscarModificarEliminar('e');

            MostrarContactos();





            Console.ReadKey();

        }



        static int PedirNoContactos()

        {

            Console.Write("Cuantos contactos desea agregar: ");

            return int.Parse(Console.ReadLine());

        }



        static string PedirDatos(string linea)

        {

            string dato = "";

            dato = "Ingrese " + linea + " : ";

            return dato;

        }



        static void GuardarContacto()

        {

            if (Contador < Contactos)

            {

                Console.Write(PedirDatos("Nombre"));

                agenda[0, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Apellido"));

                agenda[1, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Direccion"));

                agenda[2, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Telefono"));

                agenda[3, Contador] = Console.ReadLine();

                Contador++;

                Console.WriteLine("\n");

            }

            else

            {

                Console.WriteLine("Agenda llena\n");

            }

        }



        static void MostrarContactos()

        {

            for (int f = 0; f < Contador; f++)

            {

                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

            }

        }



        static void BuscarModificarEliminar(char tipo)

        {

            string buscar = "";

            for (int f = 0; f < Contactos; f++)

            {

                if (tipo == 'b')

                {

                    Console.Write("ingrese el nombre del contacto a buscar: ");

                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);

                    }

                }

                else if (tipo == 'm')

                {

                    Console.Write("ingrese el nombre del contacto a Modificar: ");

                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        Console.Write(PedirDatos("Nombre"));

                        agenda[0, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Apellido"));

                        agenda[1, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Direccion"));

                        agenda[2, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Telefono"));

                        agenda[3, f] = Console.ReadLine();

                    }

                }

                else

                {

                    Console.Write("ingrese el nombre del contacto a Borrar: ");

                    buscar = Console.ReadLine();

                    if (buscar == agenda[0, f])

                    {

                        agenda[0, f] = " ";

                        agenda[1, f] = " ";

                        agenda[2, f] = " ";

                        agenda[3, f] = " ";

                    }

                }

            }

        }

    }
   
}
