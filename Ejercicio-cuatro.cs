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

            // Iniciar el proceso principal en un hilo separado
            Task mainProcessTask = MainProcessAsync();

            // Iniciar el hilo de la barra de progreso
            Thread progressBarThread = new Thread(ProgressBarThread);
            progressBarThread.Start();

            // Esperar a que termine el proceso principal
            await mainProcessTask;

            // Esperar a que el hilo de la barra de progreso termine
            progressBarThread.Join();

            Console.WriteLine("\nProceso completado.");
        }

        static async Task MainProcessAsync()
        {
            for (int i = 0; i <= 100; i++)
            {
                // Simular una tarea que lleva tiempo
                await Task.Delay(100);

                // Informar sobre el progreso del proceso
                ReportProgress(i);
            }
        }

        static void ProgressBarThread()
        {
            while (true)
            {
                // Imprimir la barra de progreso
                Console.Write("[");

                for (int i = 0; i <= 10; i++)
                {
                    if (i <= CurrentProgress / 10)
                    {
                        Console.Write("=");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write($"] {CurrentProgress}%");

                if (CurrentProgress >= 100)
                {
                    break;
                }

                // Limpiar la línea actual en la consola y volver al principio
                Console.SetCursorPosition(0, Console.CursorTop);
            }
        }

        static int CurrentProgress = 0;

        static void ReportProgress(int progress)
        {
            // Actualizar el progreso actual de manera segura para subprocesos
            Interlocked.Exchange(ref CurrentProgress, progress);
        }
    }
}
*/