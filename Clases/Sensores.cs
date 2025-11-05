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
                Console.BackgroundColor = ConsoleColor.DarkCyan;
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
            Console.WriteLine("Monitoreo de temperatura (presiona ESC para regresar)");
            Console.WriteLine("----------------------------------------------------");

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("|                SALA A DE TURBOGENERADORES - FENIX POWER            |");
                Console.WriteLine("|   (S)                                                          (S) |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("| ACCESO  |                                        |  TABLERO DE     |");
                Console.WriteLine("| PERSONAL|                                        |  CONTROL (SCI)  |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("|               |      TURBO GENERADOR       |                       |");
                Console.WriteLine("|               |          (TG-01)           |                       |");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("| LEYENDA: (S) Sensor / (E) Entrada / (2) Historial                 |");
                Console.WriteLine("+--------------------------------------------------------------------+");

                // Simula un cambio aleatorio de temperatura
                int valorCambio = r.Next(-1, 6);
                temperatura += valorCambio;
                if (temperatura < 15) temperatura = 15;
                if (temperatura > 70) temperatura = 70;

                // Muestra siempre en la misma posición
                Console.SetCursorPosition(0, 2);
                Console.Write($"|Temperatura actual: {temperatura}°C                                 |");

                // Guarda registro
                Reg.Add(temperatura);

                // Colores y alertas
                if (temperatura >= 60)
                {
                    Console.Clear();
                    Console.Beep(800, 300);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ⚠ ALARMA: EVACUAR");
                    Console.ResetColor();
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
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.D2)
                    {
                        RegistroDeTemperaturas();
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
            Console.WriteLine("Monitoreo de temperatura (presiona ESC para regresar)");
            Console.WriteLine("----------------------------------------------------");

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("|                SALA B DE TURBOGENERADORES - FENIX POWER            |");
                Console.WriteLine("|   (S)                                                          (S) |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("| ACCESO  |                                        |  TABLERO DE     |");
                Console.WriteLine("| PERSONAL|                                        |  CONTROL (SCI)  |");
                Console.WriteLine("|=========|                                        |=================|");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("|               |      TURBO GENERADOR       |                       |");
                Console.WriteLine("|               |          (TG-02)           |                       |");
                Console.WriteLine("|               +----------------------------+                       |");
                Console.WriteLine("+--------------------------------------------------------------------+");
                Console.WriteLine("| LEYENDA: (S) Sensor / (E) Entrada / (2) Historial                 |");
                Console.WriteLine("+--------------------------------------------------------------------+");

                // Simula un cambio aleatorio de temperatura
                int valorCambio = r.Next(-1, 6);
                temperatura += valorCambio;
                if (temperatura < 15) temperatura = 15;
                if (temperatura > 70) temperatura = 70;

                // Muestra siempre en la misma posición
                Console.SetCursorPosition(0, 2);
                Console.Write($"|Temperatura actual: {temperatura}°C                                 |");

                // Guarda registro
                Reg.Add(temperatura);

                // Colores y alertas
                if (temperatura >= 60)
                {
                    Console.Clear();
                    Console.Beep(800, 300);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ⚠ ALARMA: EVACUAR");
                    Console.ResetColor();
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
