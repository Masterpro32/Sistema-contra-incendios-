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
            int opcion = 0;
            Sensores_edificio SEN = new Sensores_edificio(); 
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
            do
            {
               opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Mapa_edificio MAP = new Mapa_edificio();
                        MAP.Mapa_general();
                        break;
                    case 2:
                        Console.Clear();
                        SEN = new Sensores_edificio();
                        SEN.RegistroDeTemperaturas();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saliendo....");
                        Thread.Sleep(750);
                        break;
                    default:
                        Console.WriteLine("Opción Incorrecta");
                        Thread.Sleep(700);
                        Console.Clear();
                        paneldecontrol();
                        break;
                }
            }
            while (opcion != 3);
        }
    }
}
//Sensores SEN = new Sensores();
//SEN.CambionTemp();

//Console.SetCursorPosition(0, 0);
//Console.WriteLine("Ver registro de temperaturas? : (1)");
//int a1 = int.Parse(Console.ReadLine());
//if (a1 == 1)
//{
//    SEN.RegistroDeTemperaturas();
//}
//Console.ReadLine() ;
