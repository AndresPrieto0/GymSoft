using System;

namespace GymSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassGym gym1 = new ClassGym();

            ClassGym gym2 = new ClassGym();

            ClassGym gym3 = new ClassGym("Thiago", "Silva", 1098874626, "admin123", "Activo");

            ClassGym gym4 = new ClassGym("David","Inactivo");


            gym1.Nombre = "Santiago";
            gym1.Apellido = "Gomez";
            gym1.Documento = 1009837447;
            gym1.Clave = "user01";
            gym1.Estado = "Activo";

            gym2.IngresarDatos();
            gym2.ImprimirDatos();

            gym3.ImprimirDatos();

            gym4.ImprimirDatos();

            Console.WriteLine($"Nombre: {gym1.Nombre}");
            Console.WriteLine($"Apellido: {gym1.Apellido}");
            Console.WriteLine($"Documento: {gym1.Documento}");
            Console.WriteLine($"Clave: {gym1.Clave}");
            Console.WriteLine($"Estado: {gym1.Estado}");
            Console.ReadLine();

        }
    }
}
