using System;

namespace Mapa
{
    public class Mapa_edificio
    {
        // 🏢 Dibuja el mapa general del edificio
        public void Mapa_general()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("___________________________________");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|    Sector A   |    Sector B    |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|               |                |");
            Console.WriteLine("|_______________|________________|");
            Console.ResetColor();
        }

        // 🔧 Dibuja el plano del Sector A
        public void sectorA()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.WriteLine("|                SALA A DE TURBOGENERADORES - FENIX POWER            |");
            Console.WriteLine("+--------------------------------------------------------------------+");
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
            Console.WriteLine("| LEYENDA: (S) Sensor / (E) Entrada / (1) Historial                 |");
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.ResetColor();
        }

        // 🔧 Dibuja el plano del Sector B
        public void sectorB()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.WriteLine("|                SALA B DE TURBOGENERADORES - FENIX POWER            |");
            Console.WriteLine("+--------------------------------------------------------------------+");
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
            Console.WriteLine("| LEYENDA: (S) Sensor / (E) Entrada / (1) Historial                 |");
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.ResetColor();
        }
    }
}


