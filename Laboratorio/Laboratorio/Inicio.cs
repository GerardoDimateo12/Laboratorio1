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
            Console.WriteLine("_________________________\n       Bienvenidos       \n--------LOS PATOS--------\n_________________________");

            Console.WriteLine("Que Puesto Tienes: \n1. Administrador\n2. Trabajador\n3. Salir\n");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.WriteLine("Ingrese Nombre: ");
                zy = Console.ReadLine();

                if (usuario == zy)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese Contraseña: ");
                    yz = Console.ReadLine();

                    if (contra == yz)
                    {
                        Console.Clear();
                        Console.WriteLine("\nQue desea hacer:\n1. Ver Inventario\n2. Ver Facturas\n3. Info. Usuarios");
                        int a = int.Parse(Console.ReadLine());

                        if (a == 1)
                        {
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
                Console.WriteLine("Ingrese Nombre: ");
                xw = Console.ReadLine();
                Console.Clear();

                if (Usuario == xw)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    wx = Console.ReadLine();
                    if (Contra == wx)
                    {
                        Console.Clear();
                        Console.WriteLine("Que desea hacer:\n1. Hacer Inventario\n2. Hacer Facturas\n3. Salir");
                        int a = int.Parse(Console.ReadLine());

                        if (a == 1)
                        {
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
