
/*using System;
using System.Threading.Tasks;

namespace BarraDeEstadoConBarraCarga
{
    class ejercicio4
    {
        static bool procesoCancelado = false;

        struct Progreso
        {
            public int Porcentaje { get; set; }
            public int BarLength { get; set; }
            public int Line { get; set; }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando proceso...");

            int numTareas = 4;
            Console.WindowHeight = numTareas + 3;

            Task[] procesoTareas = new Task[numTareas];
            Progreso[] progresos = new Progreso[numTareas];

            for (int i = 0; i < numTareas; i++)
            {
                int taskId = i;
                procesoTareas[i] = EjecutarProcesoAsync(taskId, progresos);
                progresos[i].Line = i + 2;
            }

            Task barraCargaTarea = ActualizarBarraCargaAsync(procesoTareas, progresos);

            await Task.WhenAll(procesoTareas);
            procesoCancelado = true;
            await barraCargaTarea;

            Console.WriteLine("Proceso completado.");
        }

        static async Task EjecutarProcesoAsync(int taskId, Progreso[] progresos)
        {
            for (int i = 0; i <= 11; i++) // Cambia el bucle para que llegue al 100%
            {
                await Task.Delay(1000);

                if (procesoCancelado)
                {
                    Console.WriteLine($"Proceso {taskId + 1} cancelado.");
                    return;
                }

                progresos[taskId].Porcentaje = i * 10; // Ajusta el cálculo para llegar al 100%
            }
        }

        static async Task ActualizarBarraCargaAsync(Task[] procesoTareas, Progreso[] progresos)
        {
            int barLength = 100; // Cambia la longitud de la barra de carga a 100

            Console.WriteLine("Progreso:");

            while (!procesoTareas.All(t => t.IsCompleted))
            {
                for (int i = 0; i < procesoTareas.Length; i++)
                {
                    Console.SetCursorPosition(0, progresos[i].Line);
                    Console.Write($"Tarea {i + 1}: |{new string('#', progresos[i].Porcentaje / (100 / barLength)).PadRight(barLength)}| {progresos[i].Porcentaje}%");
                }

                await Task.Delay(1000);
            }
            Console.WriteLine();
        }
    }
}
*/