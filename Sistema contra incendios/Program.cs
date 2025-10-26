using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCI_T3
{
    internal class Program
    {
        static double hist1, hist2, temporaldate;
        static void Main(string[] args)
        {
            paneldecontrol();

        }
        //PANEL DE CONTROL
        static void paneldecontrol()
        {
            Console.WriteLine("                   ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            BIENVENIDO AL PANEL DE CONTROL DEL SCI            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            Sistema contra incendios - Versión 1.0            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            © 2025 - Todos los derechos reservados            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ╚══════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("             ╔══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                                                                          ║");
            Console.WriteLine("             ║ SELECCIONE QUE DESEA HACER [ Mapa General(1) // Historial (2) //Salir(3) ║");
            Console.WriteLine("             ║                                                                          ║");
            Console.WriteLine("             ╚══════════════════════════════════════════════════════════════════════════╝");
            int opcpanel = 0;
            do
            {
                opcpanel = int.Parse(Console.ReadLine());
                switch (opcpanel)
                {
                    case 1:
                        Console.Clear();
                        MapaCasa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Historial"); //falta crear codigo para el historial
                        historial();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        Console.Clear();
                        paneldecontrol();
                        break;
                }
            } while (opcpanel != 3);
        }
        //MAPA DE CASA
        static void MapaCasa()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                       TEJADO / TECHO                       ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.ResetColor();

            // Piso 2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║                        SEGUNDO PISO                        ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.ResetColor();
            Console.WriteLine("║    [ OFICINA 4 ]    [ OFICINA 5 ]    [ OFICINA 6 ]         ║");
            Console.WriteLine("║                                                            ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");

            // Piso 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║                        PRIMER PISO                         ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.ResetColor();
            Console.WriteLine("║   [ OFICINA 1 ]   [ OFICINA 2 ]   [ OFICINA 3 ]   [ BAÑO ] ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("║                   ENTRADA / RECEPCIÓN                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            menuopcpis();


        }
        // MENU DE SENSORES PISO 1
        static void Menusensores1()
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
                    MapaCasa();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, escoja una opcion valida");
                    Menusensores1();
                    break;

            }



        }
        //MAPA DEL PISO 1
        static void piso1()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  OFICINA 1        ║  OFICINA 2   ║  OFICINA 3   ║ BAÑO      ║    ║");
            Console.WriteLine("║                   ║              ║              ║           ║    ║");
            Console.WriteLine("║ (SENSOR 1)        ║ (SENSOR 2)   ║ (SENSOR 3)   ║(SENSOR 4) ║    ║");
            Console.WriteLine("║                   ║              ║              ║           ║    ║");
            Console.WriteLine("╠══════    ══════════════    ══════════    ════════════    ═══╝    ╣");
            Console.WriteLine("║                 PASILLO CENTRAL                                  ║");
            Console.WriteLine("╠     ═════════════════════════════════════════════════════════════╝");
            Console.WriteLine("║              ENTRADA / RECEPCIÓN  ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("╚═══════════════        ════════════╝");
        }
        //MENU SENSORES 2
        static void Menusensores2()
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
                        MapaCasa();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, escoja una opcion real");
                        Menusensores2();
                        break;

                }
            } while (opcionsens2 != 4);
        }
        //MAPA PISO 2
        static void piso2()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║  OFICINA 4        ║  OFICINA 5   ║  OFICINA 6   ║    ║");
            Console.WriteLine("║                   ║              ║              ║    ║");
            Console.WriteLine("║ (SENSOR 1)        ║ (SENSOR 2)   ║ (SENSOR 3)   ║    ║");
            Console.WriteLine("║                   ║              ║              ║    ║");
            Console.WriteLine("╠══════    ══════════════    ══════════    ═══════╝    ║");
            Console.WriteLine("║                 PASILLO CENTRAL                      ║");
            Console.WriteLine("═══════════════════════════════════════════════════════╝");
        }
        static void menuopcpis()

        {

            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               SELECCIÓN DE PISO A REVISAR                   ║");
            Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  - Piso 1  (1)                                              ║");
            Console.WriteLine("║  - Piso 2  (2)                                              ║");
            Console.WriteLine("║  - Volver  (3)                                              ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");

            int opcpiso = 0;
            do
            {
                opcpiso = int.Parse(Console.ReadLine());
                switch (opcpiso)
                {
                    case 1:
                        piso1();
                        Menusensores1();
                        break;
                    case 2:
                        Console.Clear();
                        piso2();
                        Menusensores2();

                        break;
                    case 3:
                        Console.Clear();
                        paneldecontrol();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("OPCION NO VALIDA, ESCOJA OTRA");
                        menuopcpis();
                        break;
                }
            } while (opcpiso != 3);
        }
        //TEMPERATURA 
        static void sensor1()
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
        static void sensor2()
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

        static void sensor3()
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
        static void sensor4()
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
        static void sensor5()
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
        static void sensor6()
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
        static void sensor7()
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
        static void alertaincendio()
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
        //historial
        static void historial()
        {
            Console.WriteLine("Historial de las ultimas 10 temperaturas");
            Console.WriteLine(hist1);
            Console.WriteLine(hist2);
        }




    }




}
