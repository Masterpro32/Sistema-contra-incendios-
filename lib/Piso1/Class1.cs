using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sensores
{
    public class SensoresGenerales
    {
        // MENU DE SENSORES PISO 1
        public double hist1, hist2;
        public void Menusensores1()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               SELECCIÓN DE SENSOR A REVISAR                 ║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  - Sensor 1  (1)                                            ║");
            Console.WriteLine("║  - Sensor 2  (2)                                            ║");
            Console.WriteLine("║  - Sensor 3  (3)                                            ║");
            Console.WriteLine("║  - Sensor 4  (4)                                            ║");
            Console.WriteLine("║  - Salir     (5)                                            ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            int opcionsens1 = 0;
            opcionsens1 = int.Parse(Console.ReadLine());
            switch (opcionsens1)
            {
                case 1:
                    Console.Clear();
                    sensor1();
                    Menusensores1();
                    break;
                case 2:
                    Console.Clear();
                    sensor2();
                    Menusensores1();
                    break;
                case 3:
                    Console.Clear();
                    sensor3();
                    Menusensores1();
                    break;
                case 4:
                    Console.Clear();
                    sensor4();
                    Menusensores1();
                    break;
                case 5:
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, escoja una opcion valida");
                    Menusensores1();
                    break;

            }
        }

        public void Menusensores2()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               SELECCIÓN DE SENSOR A REVISAR                 ║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  - Sensor 5  (1)                                            ║");
            Console.WriteLine("║  - Sensor 6  (2)                                            ║");
            Console.WriteLine("║  - Sensor 7  (3)                                            ║");
            Console.WriteLine("║  - Salir     (4)                                            ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            int opcionsens2 = 0;
            do
            {
                opcionsens2 = int.Parse(Console.ReadLine());
                switch (opcionsens2)
                {
                    case 1:
                        Console.Clear();
                        sensor5();
                        Menusensores2();
                        break;
                    case 2:
                        Console.Clear();
                        sensor6();
                        Menusensores2();
                        break;
                    case 3:
                        Console.Clear();
                        sensor7();
                        Menusensores2();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, escoja una opcion real");
                        Menusensores2();
                        break;

                }
            } while (opcionsens2 != 4);
        }

    public void sensor1()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA      ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");
                if (temperatura > 35)
                {
                    Console.Clear();
                    alertaincendio();
                }

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                    hist1 = temperatura;
                    Thread.Sleep(105);
                    hist2 = temperatura;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);

        }
        public void sensor2()
        {

            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");
                if (temperatura > 35)
                {
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep(1000, 500); // Frecuencia 1000 Hz, duración 500 ms
                        System.Threading.Thread.Sleep(200);
                    }
                    alertaincendio();
                }


                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }

        public void sensor3()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }
        public void sensor4()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }
        public void sensor5()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }
        public void sensor6()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }
        public void sensor7()
        {
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2); // 0 a 40 °C

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C");
                Console.WriteLine("╚════════════════════════════════╝");

                Console.WriteLine("\nEscribe '1' para salir del monitoreo o presiona ENTER para continuar...");

                // Espera la entrada del usuario durante 1 segundo, si no escribe nada sigue ejecutando
                int espera = 0;
                while (espera < 10) // 10 ciclos de 100 ms = 1 segundo
                {
                    if (Console.KeyAvailable)
                    {
                        string entrada = Console.ReadLine();
                        if (entrada == "1")
                        {
                            continuar = false;
                        }
                        break;
                    }

                    Thread.Sleep(100);
                    espera++;
                }
            }

            Console.Clear();
            Console.WriteLine("Monitoreo finalizado. Regresando al menú principal...");
            Thread.Sleep(1500);
        }
    public void alertaincendio()
        {
            while (true)
            {
                // Color 1: rojo intenso
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("║                [  A L E R T A  ]                       ║");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("║             ¡INCENDIO DETECTADO!                       ║");
                Console.WriteLine("║      EVACÚE INMEDIATAMENTE EL ÁREA DE RIESGO           ║");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Thread.Sleep(500);

                // Color 2: amarillo de advertencia
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("║                [  A L E R T A  ]                       ║");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("║             ¡INCENDIO DETECTADO!                       ║");
                Console.WriteLine("║      EVACÚE INMEDIATAMENTE EL ÁREA DE RIESGO           ║");
                Console.WriteLine("║                                                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Thread.Sleep(500);
            }
        }
    }
}