using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio
{
    class Inventario
    {
        static Inicio o = new Inicio();
        static string ruta = "Inventario.txt";
        static FileStream archivo;
        static StreamReader leer;
        static StreamWriter escribir;
        static int l;
        public void Inven(string Producto, string cantidad, string Precio)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine(Producto + " ---- " + cantidad + " ---- " + "Q." + Precio);
            escribir.Close();
        }
        public string Pedir(string dato)
        {
            Console.WriteLine("Ingrese" + dato + ":");
            return (Console.ReadLine());
        }

        public void I()
        {
            char menu = 's';
            while (menu != 'n')
            {
                Inven(Pedir(" Producto"), Pedir(" Cantidad"), Pedir(" Precio"));
                Console.WriteLine("Desea poner mas productos: [s/n]");
                menu = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Desea Regresar al Inicio de Sesion? [-1-]\nDesea Cerrar Programa? [-2-]");
            l = int.Parse(Console.ReadLine());
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
        public void Inv()
        {
            Console.ReadLine();
            TextReader Leer;
            Leer = new StreamReader(ruta);
            Console.WriteLine(Leer.ReadToEnd());

            Console.WriteLine("Desea Regresar al Inicio de Sesion? [-1-]\nDesea Cerrar Programa? [-2-]");
            l = int.Parse(Console.ReadLine());
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
    }

}
