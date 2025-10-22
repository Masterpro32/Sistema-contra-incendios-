using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCI_T3
{
    internal class Program
    {
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
                    Console.WriteLine("Sensor 2");
                    Menusensores1();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Sensor 3");
                    Menusensores1();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Sensor 4");
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
                        Console.WriteLine("Sensor 5");
                        Menusensores2();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sensor 6");
                        Menusensores2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Sensor 7");
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

            while (true) // bucle infinito (simula monitoreo continuo)
            {
                Console.Clear();

                double temperatura = Math.Round(random.NextDouble() * 40, 2);
                // genera un número entre 0.00 y 40.00 grados

                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║  MONITOREO DE TEMPERATURA     ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine($"║  Temperatura actual: {temperatura} °C     ");
                Console.WriteLine("╚════════════════════════════════╝");

                Thread.Sleep(1000);
            }




        }




    }
}
