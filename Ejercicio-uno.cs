/*
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            // Crear una tarea 'a' que imprimirá números del 0 al 10 en el hilo 1
            var a = new Task(() =>
            {
                for (int x = 0; x <= 10; x++)
                {
                    Console.WriteLine("Hilo 1: Numero " + x);
                }
            });

            // Crear una tarea 'b' que imprimirá números del 0 al 20 que sean divisibles por 2
            var b = new Task(() =>
            {
                int y;

                for (y = 0; y <= 20; y++)
                {
                    if (y % 2 == 0)
                    {
                        Console.WriteLine("Este nuemro " + y + " es divisible por 2");
                    }
                }
            });

            // Crear una tarea 'c' que imprimirá el número de vuelta del 0 al 6
            var c = new Task(() =>
            {
                for (int x = 0; x <= 6; x++)
                {
                    Console.WriteLine("Vuelta: N° " + x);
                }
            });

            // Crear una tarea 'd' que imprimirá los meses del año con su número correspondiente
            var d = new Task(() =>
            {
                string[] meses = {
                    "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                    "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
                };

                Console.WriteLine("Los meses del año son:");
                for (int i = 0; i < meses.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {meses[i]}");
                }
            });

            // Crear una tarea 'e' que imprimirá un mensaje mil veces
            var e = new Task(() =>
            {
                for (int x = 0; x <= 1000; x++)
                {
                    Console.WriteLine("Perdon no se que mas hacer");
                }
            });

            // Iniciar la tarea 'a' y esperar a que termine
            a.Start();
            a.Wait();

            // Iniciar la tarea 'b' y esperar a que termine
            b.Start();
            b.Wait();

            // Iniciar la tarea 'c' y esperar a que termine
            c.Start();
            c.Wait();

            // Iniciar la tarea 'd' y esperar a que termine
            d.Start();
            d.Wait();

            // Iniciar la tarea 'e' y esperar a que termine
            e.Start();
            e.Wait();
        }
    }
}
*/

/* para nuevos comentarios 

git add .
git commit -m "lo que cambio"
git push

*/