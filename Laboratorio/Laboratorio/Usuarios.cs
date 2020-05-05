using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio
{
    class Usuarios
    {
        static Inicio o = new Inicio();
        static string ruta2 = "Usuarios.txt";
        static StreamWriter escribir;
        public int menu;
        
        public void Puesto(string puesto, string a)
        {
            Console.Clear();
            Console.WriteLine("                    _________________________\n                           Bienvenidos\n                    --------LOS PATOS--------\n                    _________________________");
            Console.WriteLine("              Que puesto tendra el nuevo usuario?\n                       1. Administrador\n                       2. Trabajador");
            menu = int.Parse(Console.ReadLine());
            Console.Clear();

            if (menu == 1)
            {
                escribir = File.AppendText(ruta2);
                escribir.WriteLine("Nombre del Nuevo: " + puesto + "\n Contraseña: " + a);
                escribir.WriteLine("----Administrador----");
                o.usua1 = puesto;
                o.contra1 = a;
                escribir.Close();
            }
            if (menu == 2)
            {
                escribir = File.AppendText(ruta2);
                escribir.WriteLine("Nombre del Nuevo usuario: " + puesto + "\n Contraseña: " + a);
                escribir.WriteLine("----Trabajador----");
                o.usua2 = puesto;
                o.contra2 = a;
                escribir.Close();
            }
        }
        public string Pedir(string dato)
        {
            Console.WriteLine("Ingrese " + dato + " :");
            return (Console.ReadLine());
        }
        public void Usua()
        {
            char Menu = 's';
            while(Menu!='n')
            {
                Puesto(Pedir("Nombre del Nuevo usuario"), Pedir("Contraseña"));
                escribir = File.AppendText(ruta2);
                escribir.Close();
                Console.Clear();
                Console.WriteLine("Desea crear otro usuario? [s/n]");
                Menu = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            escribir = File.AppendText(ruta2);
            escribir.WriteLine("\n");
            escribir.Close();
            Console.Clear();
            Console.WriteLine("Desea Regresar al Inicio de Sesion? [-1-]\nDesea Cerrar Programa? [-2-]");
            int a = int.Parse(Console.ReadLine());

            if (a==1)
            {
                Console.Clear();
                o.Usuarios();
            }
            if (a==2)
            {
                Console.Clear();
            }

        }
        public void Usuar()
        {
            Console.ReadLine();
            TextReader Leer;
            Leer = new StreamReader(ruta2);
            Console.WriteLine(Leer.ReadToEnd());

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
    }
}
