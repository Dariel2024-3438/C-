namespace _juan_perez_tarea_2_
{
     class Estudiante
    {
        // Propiedades con get y set
        public string Nombre { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        // Método para calcular el promedio
        public double CalcularPromedio()
        {
            double promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return promedio;
        }

        // Método para determinar si aprobó
        public string ObtenerEstatus()
        {
            if (CalcularPromedio() >= 70)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("   PROGRAMA DE CALCULO DE PROMEDIOS  ");
            Console.WriteLine("=====================================");
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            // Bucle para procesar todos los estudiantes
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Estudiante " + i);
                Console.WriteLine("-----------------------------");

                Estudiante est = new Estudiante();

                Console.Write("Nombre del estudiante: ");
                est.Nombre = Console.ReadLine();

                Console.Write("Primera nota: ");
                est.Nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Segunda nota: ");
                est.Nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Tercera nota: ");
                est.Nota3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Cuarta nota: ");
                est.Nota4 = Convert.ToDouble(Console.ReadLine());

                double promedio = est.CalcularPromedio();
                string estatus = est.ObtenerEstatus();

                Console.WriteLine("");
                Console.WriteLine("Resultado del estudiante:");
                Console.WriteLine("Nombre: " + est.Nombre);
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Estatus: " + estatus);
                Console.WriteLine("");
                Console.WriteLine("===============================");
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}
