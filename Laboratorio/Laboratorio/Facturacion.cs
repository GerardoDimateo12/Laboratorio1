using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Laboratorio
{
    class Facturacion
    {
        static Inicio o = new Inicio();
        static string ruta1 = "Facturacion.txt";
        static StreamWriter escribir;
        static int f;
        
        public void Facturas()
        {
            Console.ReadLine();
            TextReader Leer;
            Leer = new StreamReader(ruta1);
            Console.WriteLine(Leer.ReadToEnd());

            Console.WriteLine("Desea Regresar al Inicio de Sesion? [-1-]\nDesea Cerrar Programa? [-2-]");
            f = int.Parse(Console.ReadLine());
            if (f == 1)
            {
                Console.Clear();
                o.Usuarios();
            }
            if (f == 2)
            {
                Console.Clear();
            }
        }
        public string Pedir(string dato)
        {
            Console.WriteLine("Ingrese " + dato + ":");
            return (Console.ReadLine());
        }
        public void Factu(string Producto, string cantidad, string Precio)
        {
            escribir = File.AppendText(ruta1);
            escribir.WriteLine(Producto + " ---- " + cantidad + " ---- " + "Q." + Precio);
            escribir.Close();
        }
        public void F()
        {
            Factur(Pedir("Nombre"), Pedir("NIT"), Pedir("Fecha"));
            char menu = 's';
            while (menu != 'n')
            {
                Console.Clear();
                Factu(Pedir(" Producto"), Pedir(" Cantidad"), Pedir(" Precio"));
                Console.WriteLine("Desea poner mas productos: [s/n]\n\n");
                menu = char.Parse(Console.ReadLine());
            }
            
            Console.Clear();
            Console.WriteLine("Desea Regresar al Inicio de Sesion? [-1-]\nDesea Cerrar Programa? [-2-]");
            int l = int.Parse(Console.ReadLine());

            if (l == 1)
            {
                Console.Clear();
                o.Usuarios();
            }
            if (l == 2)
            {
                Console.Clear();
            }
        }
        public void Factur(string Nombre, string NIT, string Fecha)
        {
            escribir = File.AppendText(ruta1);
            escribir.WriteLine("\nNombre: " + Nombre + "----" +"NIT: "+ NIT + "----------------" + "Fecha: " + Fecha+ "\n");
            escribir.Close();
        }

    }
}

