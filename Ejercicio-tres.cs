/*
using System;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    { 
        static async Task Main(string[] args)
        {
            // Muestra un mensaje de bienvenida al juego.
            Console.WriteLine("Bienvenido al juego de Piedra, Papel y Tijera entre BOTs");

            // Crea una instancia de la clase Random para generar números aleatorios.
            Random random = new Random();

            // Inicia un bucle infinito para jugar varias veces.
            while (true)
            {
                // Genera elecciones aleatorias para ambos jugadores.
                int jugador1 = random.Next(1, 4);
                int jugador2 = random.Next(1, 4);

                // Llama a la función JugarAsync para determinar el resultado del juego.
                Resultado resultado =  await JugarAsync(jugador1, jugador2);

                // Muestra las elecciones y el resultado del juego.
                Console.WriteLine($"Jugador 1 eligió: {Enum.GetName(typeof(Opcion), jugador1)}");
                Console.WriteLine($"Jugador 2 eligió: {Enum.GetName(typeof(Opcion), jugador2)}");
                Console.WriteLine($"Resultado: {resultado}\n");

                // Pregunta al usuario si desea jugar de nuevo y lee la respuesta.
                Console.WriteLine("Desea jugar de nuevo?");
                string respuesta = Console.ReadLine();

                // Si la respuesta no es "s", sale del bucle.
                if(respuesta.ToLower() != "s")
                {
                    break;
                }
            }
        }

        // Enumeración que representa las opciones de juego.
        enum Opcion{
            Piedra = 1,
            Papel = 2,
            Tijera = 3
        }
        
        // Enumeración que representa los posibles resultados del juego.
        enum Resultado{
            Empate,
            Jugador_1_Gana,
            Jugador_2_Gana
        }

        // Función asincrónica que determina el resultado del juego.
        static async Task<Resultado> JugarAsync (int jugador1, int jugador2)
        {
            // Convierte los números de los jugadores en opciones.
            Opcion opcion1 = (Opcion)jugador1;
            Opcion opcion2 = (Opcion)jugador2;

            // Agrega un retraso simulado de 100 ms (opcional).
            await Task.Delay(100);

            // Compara las elecciones de los jugadores para determinar el resultado.
            if(opcion1 == opcion2)
            {
                return Resultado.Empate;
            }
            else if((opcion1 == Opcion.Piedra && opcion2 == Opcion.Tijera) ||
                     (opcion1 == Opcion.Papel && opcion2 == Opcion.Piedra) ||
                     (opcion1 == Opcion.Tijera && opcion2 == Opcion.Papel))
            {
                return Resultado.Jugador_1_Gana;
            }
            else
            {
                return Resultado.Jugador_2_Gana;
            }
        }
    }
}
*/