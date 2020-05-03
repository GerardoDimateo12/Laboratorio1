using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Laboratorio
{
    class Program
    {
        static string ruta = "Inventario.txt";
        static FileStream archivo;
        static StreamReader leer;
        static StreamWriter escribir;

        static void Main(string[] args)
        {
            string f;
            string usuario = "Gerardo", contra = "123", Usuario = "Antonio", Contra = "456", zy, yz, xw, wx;
            Console.WriteLine("_________________________\n       Bienvenidos       \n--------LOS PATOS--------\n_________________________");

            Console.WriteLine("Que Puesto Tienes: \n1. Administrador\n2. Trabajador\n3. Salir\n");
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                char USU = 's';
                while (USU != 'n')
                {
                    Console.WriteLine("Ingrese Nombre: ");
                    zy = Console.ReadLine();

                    if (usuario == zy)
                    {
                        char usu = 's';
                        while (usu != 'n')
                        {
                            Console.WriteLine("Ingrese Clave: ");
                            yz = Console.ReadLine();

                            if (contra == yz)
                            {
                                char op = 's';
                                while (op != 'n')
                                {
                                    Console.WriteLine("\nQue desea hacer:\n1. Ver Inventario\n2. Ver Facturas\n3. Info. Usuarios");
                                    int a = int.Parse(Console.ReadLine());

                                    if (a == 1)
                                    {
                                        Console.ReadLine();
                                        TextReader Leer;
                                        Leer = new StreamReader(ruta);
                                        Console.WriteLine(Leer.ReadToEnd());
                                    }
                                    if (a == 2)
                                    {

                                    }
                                    if (a == 3)
                                    {

                                    }
                                    Console.WriteLine("\nDesea realizar otro trabajo: [s/n]");
                                    op = char.Parse(Console.ReadLine());
                                }
                            }
                        }
                    }
                }
            }
            if (m == 2)
            {
                char USU = 's';
                while (USU != 'n')
                {
                    Console.WriteLine("Ingrese Nombre: ");
                    xw = Console.ReadLine();

                    if (Usuario == xw)
                    {
                        char usu = 's';
                        while (usu != 'n')
                        {
                            Console.WriteLine("Ingrese Clave: ");
                            wx = Console.ReadLine();

                            if (Contra == wx)
                            {
                                char op = 's';
                                while (op != 'n')
                                {
                                    Console.WriteLine("Que desea hacer:\n1. Hacer Inventario\n2. Hacer Facturas\n3. Salir");
                                    int a = int.Parse(Console.ReadLine());

                                    if (a == 1)
                                    {
                                        char menu = 's';

                                        while (menu != 'n')
                                        {
                                            Inventario(Pedir(" Producto"), Pedir(" Cantidad"), Pedir(" Precio"));
                                            Console.WriteLine("Desea poner mas productos: [s/n]");
                                            menu = char.Parse(Console.ReadLine());
                                        }
                                    }
                                    if (a == 2)
                                    {

                                    }
                                    if (m == 3)
                                    {
                                        Console.Clear();
                                    }
                                    Console.WriteLine("Desea realizar otro trabajo: [s/n]");
                                    op = char.Parse(Console.ReadLine());
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        static void Inventario(string Producto, string cantidad, string Precio)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine(Producto + " ---- " + cantidad + " ---- " + "Q." + Precio);
            escribir.Close();
        }
        static string Pedir(string dato)
        {
            Console.WriteLine("Ingrese" + dato + ":");
            return (Console.ReadLine());
        }
    }
}
