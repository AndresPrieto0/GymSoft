using System;
using System.Collections.Generic;
using System.Text;

namespace GymSoft
{
    class ClassGym
    {


        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        #endregion


        #region Metodos
        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese el Nombre ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido ");
            Apellido = (Console.ReadLine());
            Console.WriteLine("Ingrese el documento ");
            Documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la clave ");
            Clave = Console.ReadLine();
            Console.WriteLine("Ingrese el estado");
            Estado = Console.ReadLine();

        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Documento: {Documento}");
            Console.WriteLine($"Clave: {Clave}");
            Console.WriteLine($"Estado: {Estado}");
        }
        #endregion


        public ClassGym(string nombre, string apellido, int documento, string clave, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Clave = clave;
            Estado = estado;

        }

        public ClassGym()
        {

        }


        public ClassGym(string nombre, string estado)
        {
            Nombre = nombre;
            Estado = estado;
        }


    }

}
