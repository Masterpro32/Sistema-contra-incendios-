using Sensores;
using Mapa;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_SISCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            paneldecontrol();
        }
        static void paneldecontrol()
        {
            Console.WriteLine("                   ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            BIENVENIDO AL PANEL DE CONTROL DEL SCI            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            Sistema contra incendios - Versión 1.0            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ║            © 2025 - Todos los derechos reservados            ║");
            Console.WriteLine("                   ║                                                              ║");
            Console.WriteLine("                   ╚══════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("             ╔══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                                                                          ║");
            Console.WriteLine("             ║        SELECCIONE QUE DESEA HACER [ Mapa General(1) // Salir(2)          ║");
            Console.WriteLine("             ║                                                                          ║");
            Console.WriteLine("             ╚══════════════════════════════════════════════════════════════════════════╝");

            MenuGeneral();

        }
        static void MenuGeneral()
        {
            int opcion;
            do
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        MenuTurbo();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Saliendo....");
                        Thread.Sleep(550);
                        break;
                    default:
                        Console.WriteLine("Opción Incorrecta");
                        Thread.Sleep(700);
                        Console.Clear();
                        paneldecontrol();
                        break;
                }
            }
            while (opcion != 2);
        }
        static void MenuTurbo()
        {
            Mapa_edificio MAP = new Mapa_edificio();
            MAP.Mapa_general();
            Console.WriteLine("Seleccione el sector que desea visualizar: ");
            Console.WriteLine("(0) Volver al menú principal \n(1) Sector A \n(2) Sector B");
            int opcion1 = int.Parse(Console.ReadLine());
            switch (opcion1)
            {
                case 0:
                    Console.Clear();
                    paneldecontrol();
                    MenuGeneral();
                    break;
                case 1:
                    Console.Clear();
                    MAP.sectorA();
                    MenuSectorA();
                    break;
                case 2:
                    Console.Clear();
                    MAP.sectorB();
                    MenuSectorB();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida, por favor seleccione 0, 1, 2, 3 o 4 ");
                    break;
            }
        }
        static void MenuSectorA()
        {

            Mapa_edificio MAP = new Mapa_edificio();
            Sensores_edificio SEN = new Sensores_edificio();
            MAP.sectorA();
            SEN.SensorA();
            Console.WriteLine("Seleccione el sector que desea visualizar: ");
            Console.WriteLine("(0)Regresar\n(1)Sensor A\n(2)Historial");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Console.Clear();
                    MenuTurbo();
                    break;
                case 1:
                    Console.Clear();
                    SEN.SensorA();
                    break;
                case 2:
                    Console.Clear();
                    SEN.RegistroDeTemperaturas();
                    HistorialA();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida, por favor seleccione 0, 1, 2, 3 o 4 ");
                    break;
            }
        }
            static void MenuSectorB()
        {

            Mapa_edificio MAP = new Mapa_edificio();
            Sensores_edificio SEN = new Sensores_edificio();
            MAP.sectorB();
            SEN.SensorB();
            Console.WriteLine("Seleccione el sector que desea visualizar: ");
            Console.WriteLine("(0)Regresar\n(1)Sensor B\n(2)Historial");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Console.Clear();
                    MenuTurbo();
                    break;
                case 1:
                    Console.Clear();
                    SEN.SensorB();
                    break;
                case 2:
                    Console.Clear();
                    SEN.RegistroDeTemperaturas();
                    HistorialB();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida, por favor seleccione 0, 1, 2, 3 o 4 ");
                    break;
            }
        }
            static void HistorialA() 
            {
            do
            { 
            Console.WriteLine("Seleccione una opción:\n(0)Regresar\n(1)Borrar Historial");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) 
                {
                case 0:
                    Console.Clear();
                    MenuSectorA();
                    break;
                case 1: 
                    Console.Clear();
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Opción no válida, por favor seleccione 0, 1, 2, 3 o 4 ");
                    break;
                }
            } while (true);
        }
            static void HistorialB()
            {
                do
                {
                    Console.WriteLine("Seleccione una opción:\n(0)Regresar\n(1)Borrar Historial");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 0:
                            Console.Clear();
                            MenuSectorB();
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida, por favor seleccione 0, 1, 2, 3 o 4 ");
                            break;
                    }
                } while (true);

            }


    }   
}





