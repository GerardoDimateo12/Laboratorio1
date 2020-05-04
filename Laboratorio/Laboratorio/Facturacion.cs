using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio
{
    class Facturacion
    {
        static Inicio o = new Inicio();
        static string ruta1 = "Facturacion.txt";
        static FileStream archivo;
        static StreamReader leer;
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
        
    }
}
