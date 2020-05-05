using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio
{
    class Inicio
    {
        static Inventario In = new Inventario();
        static Facturacion Fac = new Facturacion();
        static Usuarios Us = new Usuarios();
        public string usua1 = "Gerardo", contra1 = "123", usua2 = "Antonio", contra2 = "456", zy, yz, xw, wx;
        public void Usuarios()
        { 
            Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");
            Console.WriteLine("\n                       Que Puesto Tienes: \n                        1. Administrador\n                        2. Trabajador\n                        3. Salir\n");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.Clear();
                Console.WriteLine("\n-----REGISTRO-----");
                Console.WriteLine("Ingrese Nombre: ");
                zy = Console.ReadLine();

                if (usua1 == zy)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    yz = Console.ReadLine();

                    if (contra1 == yz)
                    {
                        Console.Clear();
                        Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");
                        Console.WriteLine("\n                         Que desea hacer:\n                          1. Ver Inventario\n                          2. Ver Facturas\n                          3. Info. Usuarios");
                        int a = int.Parse(Console.ReadLine());

                        if (a == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n--------INVENTARIO--------");
                            In.Inv();
                        }
                        if (a == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\n--------FACTURAS--------");
                            Fac.Facturas();
                        }
                        if (a == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Que Quiere hacer?\n 1. Crear Usuarios\n 2. Ver Usuarios");
                            int h = int.Parse(Console.ReadLine());
                            if (h == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n--------CREAR-USUARIOS--------\n");
                                Us.Usua();
                            }
                            if (h == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\n--------USUARIOS--------");
                                Us.Usuar();
                            }
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
           
                if (usua2 == xw)
                {
                    Console.WriteLine("Ingrese Contraseña: ");
                    wx = Console.ReadLine();
                    if (contra2 == wx)
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
                            Console.Clear();
                            Fac.F();
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
