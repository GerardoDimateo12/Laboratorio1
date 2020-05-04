using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio
{
    class Inicio
    {
        static Inventario In = new Inventario();
        public void Usuarios()
        {
            string usuario = "Gerardo", contra = "123", Usuario = "Antonio", Contra = "456", zy, yz, xw, wx;
            Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");

            Console.WriteLine("\n                       Que Puesto Tienes: \n                        1. Administrador\n                        2. Trabajador\n                        3. Salir\n");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.Clear();
                Console.WriteLine("\n-----REGISTRO-----");
                Console.WriteLine("Ingrese Nombre: ");
                zy = Console.ReadLine();

                if (usuario == zy)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    yz = Console.ReadLine();

                    if (contra == yz)
                    {
                        Console.Clear();
                        Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");
                        Console.WriteLine("\n                         Que desea hacer:\n                          1. Ver Inventario\n                          2. Ver Facturas\n                          3. Info. Usuarios");
                        int a = int.Parse(Console.ReadLine());

                        if (a == 1)
                        {
                            Console.Clear();
                            In.Inv();
                        }
                        if (a == 2)
                        {

                        }
                        if (a == 3)
                        {

                        }

                    }
                }
            }
            if (m == 2)
            {
                Console.Clear();
                Console.WriteLine("\n-----REGISTRO-----");
                Console.WriteLine("Ingrese Nombre: ");
                xw = Console.ReadLine();
           
                if (Usuario == xw)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    wx = Console.ReadLine();
                    if (Contra == wx)
                    {
                        Console.Clear();
                        Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");
                        Console.WriteLine("\n                         Que desea hacer:\n                        1. Hacer Inventario\n                        2. Hacer Facturas\n                        3. Salir");
                        int a = int.Parse(Console.ReadLine());

                        if (a == 1)
                        {
                            Console.Clear();
                            In.I();
                        }
                        if (a == 2)
                        {

                        }
                        if (m == 3)
                        {
                            Console.Clear();
                        }

                    }
                }

            }
            if (m == 3)
            {
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
