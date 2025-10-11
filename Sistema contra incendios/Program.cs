using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            paneldecontrol();

        }
        static void paneldecontrol()
        {
            Console.WriteLine("BIENVENIDO AL PANEL DE CONTROL");
            Console.WriteLine("SELECCIONE QUE DESEA HACER [ Mapa General(1) // Historial (2)");
            int opcpanel = 0;
            opcpanel = int.Parse(Console.ReadLine());


            Console.WriteLine("");
            switch (opcpanel)
            {
                case 1:
                    MapaCasa();
                    break;
                case 2:
                    Console.WriteLine("Historial");
                    break;

            }
        }
        static void MapaCasa()
        {
            Console.WriteLine(" _______________________________________________ ");
            Console.WriteLine("|                   TEJADO / TECHO              |");
            Console.WriteLine("|-----------------------------------------------|");

            // Piso 2
            Console.WriteLine("|                SEGUNDO PISO                   |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|   | | OFICINA 4 | OFICINA 5| OFICINA 6   |    |");
            Console.WriteLine("|                                               |  ");
            Console.WriteLine("|-----------------------------------------------|");

            // Piso 1
            Console.WriteLine("|                PRIMER PISO                    |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|  OFICINA 1  |  OFICINA 2 |  OFICINA 3| BAÑO   |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|                ENTRADA / RECEPCION|");
            Console.WriteLine("|_______________________________________________|");

            Console.WriteLine("SELECCIONE EL PISO A REVISAR [ Piso 1 (1) // Piso 2 (2) // Volver (3) ]");
            int opcpiso = int.Parse(Console.ReadLine());
            switch (opcpiso)
            {
                case 1:
                    piso1();
                    break;
                case 2:
                    piso2();
                    break;
                case 3:
                    paneldecontrol();
                    break;
            }

        }
        static void piso1()
        {
            Console.WriteLine(" ___________________________________________________________ ");
            Console.WriteLine("|  OFICINA 1   |  OFICINA 2   |  OFICINA 3   |    BAÑO     |");
            Console.WriteLine("|--------------|--------------|--------------|-------------|");
            Console.WriteLine("| (SENSOR 1)   | (SENSOR 2)   |(SENSOR 3)    |  (SENSOR 4) |");
            Console.WriteLine("|______  ______|______  ______|_____  _______|______  _____|");
            Console.WriteLine("|                PASILLO CENTRAL                           |");
            Console.WriteLine("|__________________________________________________________|");
            Console.WriteLine("|             ENTRADA / RECEPCIÓN               |");
            Console.WriteLine("|_________________        ______________________|");
        }
        static void piso2()
        {
            Console.WriteLine(" ____________________________________________ ");
            Console.WriteLine("|   OFICINA 1   |   OFICINA 2   |  OFICINA 3  |");
            Console.WriteLine("|---------------|---------------|-------------|");
            Console.WriteLine("| (SENSOR 5)    | (SENSOR 6)    | (SENSOR 7)  |");
            Console.WriteLine("|______  _______|_______  ______|______  _____|");
            Console.WriteLine("|               PASILLO CENTRAL               |");
            Console.WriteLine("|____________________________________________ |");
        }


    }
}