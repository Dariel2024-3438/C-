calculo de promedio

Tarea 2 – Flujo de Control Parte 2

Descripción
Este programa solicita las cuatro calificaciones de una cantidad determinada de estudiantes, calcula el promedio de cada uno y muestra si aprobó o reprobó.  
Los resultados se muestran en formato de tabla.

Características
- Permite ingresar varios estudiantes mediante un bucle.
- Usa una clase **Estudiante** con propiedades (`get` y `set`).
- Incluye métodos para calcular el promedio y el estatus.

Ejemplo de ejecución

=====================================
   PROGRAMA DE CALCULO DE PROMEDIOS
=====================================

Ingrese la cantidad de estudiantes: 2

Estudiante            Nota1   Nota2   Nota3   Nota4   Promedio   Estatus
--------------------------------------------------------------------------

Estudiante 1
-----------------------------
Nombre del estudiante: Penencio Rodríguez
Primera nota: 75
Segunda nota: 71
Tercera nota: 80
Cuarta nota: 84

Estudiante 2
-----------------------------
Nombre del estudiante: Bulbania Rivera
Primera nota: 65
Segunda nota: 69
Tercera nota: 70
Cuarta nota: 61

Penencio Rodríguez    75      71      80      84      77.5    Aprobado
Bulbania Rivera       65      69      70      61      66.25   Reprobado

programa
(capturas)

<img width="897" height="540" alt="tarea 2" src="https://github.com/user-attachments/assets/3ef378f5-cd2c-4c7e-aefc-bc71391acba7" />

otro ejemplo:
<img width="904" height="540" alt="1 2" src="https://github.com/user-attachments/assets/a6060b2f-4d5b-4415-a7ff-633f490b3ad3" />

<img width="900" height="540" alt="2 2" src="https://github.com/user-attachments/assets/109be239-68fa-4a7a-9a6f-b77e5ce4279e" />

codigo:

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




