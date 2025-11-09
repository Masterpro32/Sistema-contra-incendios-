using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sensores
{
    public class Sensores_edificio
    {
        Random r = new Random(); //Variables de clase
        int TempPreterminada = 25; //Variables de clase
        List<int> Reg = new List<int>();
        public void RegistroDeTemperaturas()
        {
            DateTime fecha = DateTime.Now;
            int cont = 1;
            foreach (int temporal in Reg)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"FECHA {fecha}");
                Console.WriteLine($"REGISTRO DE TEMPERATURA ({cont}): {temporal}°C");
                Console.ResetColor();
                cont++;
            }
        }
        public void SensorA()
        {
            int temperatura = TempPreterminada; // temperatura base
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Monitoreo de temperatura (presiona ESC para abrir menú)");
            Console.WriteLine("----------------------------------------------------");

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("|                SALA A DE TURBOGENERADORES - FENIX POWER            |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("| ACCESO  |                                        |  TABLERO DE     |");
                Console.WriteLine("| PERSONAL|                                        |  CONTROL (SCI)  |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("|               |      TURBO GENERADOR       |                       |");
                Console.WriteLine("|               |          (TG-01)           |                       |");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("+--------------------------------------------------------------------+");

                // Simula un cambio aleatorio de temperatura
                int valorCambio = r.Next(-1, 6);
                temperatura = temperatura + valorCambio;
                if (temperatura < 15) 
                {
                    temperatura = 15; //Limita la temperatura por si disminuye demasiado
                }

                // Muestra siempre en la misma posición
                Console.SetCursorPosition(0, 2);
                Console.Write($"|Temperatura actual: {temperatura}°C    |  SENSOR DE HUMO: NORMAL   |");

                // Guarda registro
                if (temperatura >= 40)
                {
                    Reg.Add(temperatura);
                }
                // Colores y alertas
                if (temperatura >= 60)
                {
                    Console.Clear();
                    Console.Beep(800, 300);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" ⚠ ALARMA: EVACUAR INMEDIATAMENTE {temperatura}°C | SENSORES DE HUMO: ALERTA DE HUMO");
                    Console.ResetColor();
                    Console.WriteLine("Monitoreo de temperatura (presiona ESC para abrir menú)");
                }
                else if (temperatura >= 40)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("  Advertencia: Alta temperatura ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  Estado normal               ");
                    Console.ResetColor();
                }

                // Permite salir con ESC
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Monitoreo detenido. Volviendo al menú...");
                        Thread.Sleep(1000);
                        break;
                    }
                }

                Thread.Sleep(700); // actualiza cada 0.7 segundos
            }
        }
    public void SensorB()
        {
            int temperatura = TempPreterminada; // temperatura base
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Monitoreo de temperatura (presiona ESC para abrir menú)");
            Console.WriteLine("----------------------------------------------------");

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("|                SALA B DE TURBOGENERADORES - FENIX POWER            |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                 +----------------------------+                     |");
                Console.WriteLine("|                 |     TURBO GENERADOR        |                     |");
                Console.WriteLine("|                 |         (TG-02)            |                     |");
                Console.WriteLine("|                 +----------------------------+                     |");
                Console.WriteLine("|=================|                                    |=========|   |");
                Console.WriteLine("| TABLERO DE      |                                    | ACCESO  |   |");
                Console.WriteLine("| CONTROL (SCI)   |                                    | PERSONAL|   |");
                Console.WriteLine("|=================|                                    |=========|   |");
                Console.WriteLine("+--------------------------------------------------------------------+");

                // Simula un cambio aleatorio de temperatura
                int valorCambio = r.Next(-1, 6);
                temperatura = temperatura + valorCambio;
                if (temperatura < 15)
                {
                    temperatura = 15; //Limita la temperatura por si disminuye demasiado
                }

                // Muestra siempre en la misma posición
                Console.SetCursorPosition(0, 2);
                Console.Write($"|Temperatura actual: {temperatura}°C    |  SENSOR DE HUMO: NORMAL   |");

                // Guarda registro
                if (temperatura >= 40) 
                { 
                    Reg.Add(temperatura);
                }
                // Colores y alertas
                if (temperatura >= 60)
                {
                    Console.Clear();
                    Console.Beep(800, 300);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" ⚠ ALARMA: EVACUAR INMEDIATAMENTE {temperatura}°C | SENSORES DE HUMO: ALERTA DE HUMO");
                    Console.ResetColor();
                    Console.WriteLine("Monitoreo de temperatura (presiona ESC para abrir menú)");
                }
                else if (temperatura >= 40)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("  Advertencia: Alta temperatura ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  Estado normal               ");
                    Console.ResetColor();
                }

                // Permite salir con ESC
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Monitoreo detenido. Volviendo al menú...");
                        Thread.Sleep(1000);
                        break;
                    }
                }

                Thread.Sleep(700); // actualiza cada 0.7 segundos
            }
        }
    }
}







