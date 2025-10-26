using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sensores;
namespace SCI_T3
{
    class Program
    {
        static double hist1, hist2, temporaldate;
        static void Main(string[] args)
        {       
            paneldecontrol();
            SensoresGenerales sensores = new SensoresGenerales();
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
            SensoresGenerales sensores = new SensoresGenerales();

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
                        sensores.Menusensores1();
                        break;
                    case 2:
                        Console.Clear();
                        piso2();
                        sensores.Menusensores2();
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
        
        
        //historial
        static void historial()
        {
            Console.WriteLine("Historial de las ultimas 10 temperaturas");
            Console.WriteLine(hist1);
            Console.WriteLine(hist2);
        }




    }




}
