/*
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando proceso...");

            // Crear un array de tareas para los 4 procesos
            Task[] processTasks = new Task[4];

            // Iniciar los 4 procesos en paralelo
            for (int i = 0; i < processTasks.Length; i++)
            {
                processTasks[i] = MainProcessAsync(i + 1);
            }

            // Iniciar el hilo de la barra de progreso
            Thread progressBarThread = new Thread(ProgressBarThread);
            progressBarThread.Start();

            // Esperar a que todas las tareas de proceso terminen
            await Task.WhenAll(processTasks);

            // Detener el hilo de la barra de progreso
            progressBarThread.Join();

            Console.WriteLine("\nProceso completado.");
        }

        static async Task MainProcessAsync(int processNumber)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Simular una tarea que lleva tiempo
                await Task.Delay(100);

                // Informar sobre el progreso del proceso
                ReportProgress(processNumber, i);
            }
        }

        static void ProgressBarThread()
        {
            while (true)
            {
                // Imprimir la barra de progreso general
                Console.Write("[");

                int overallProgress = CalculateOverallProgress();

                for (int i = 0; i <= 40; i++)
                {
                    if (i <= overallProgress / 10)
                    {
                        Console.Write("=");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write($"] {overallProgress}%");

                if (overallProgress >= 400) // 4 procesos * 100%
                {
                    break;
                }

                // Limpiar la línea actual en la consola y volver al principio
                Console.SetCursorPosition(0, Console.CursorTop);
            }
        }

        static int[] CurrentProgress = new int[4];

        static void ReportProgress(int processNumber, int progress)
        {
            // Actualizar el progreso actual del proceso específico de forma segura
            Interlocked.Exchange(ref CurrentProgress[processNumber - 1], progress);
        }

        static int CalculateOverallProgress()
        {
            // Calcular el progreso general de los 4 procesos
            int overallProgress = 0;
            foreach (int progress in CurrentProgress)
            {
                overallProgress += progress;
            }
            return overallProgress;
        }
    }
}
*/