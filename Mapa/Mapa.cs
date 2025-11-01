using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa
{
    public class Mapa_edificio
    {
        public void Mapa_general()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("__________________________________");
            Console.WriteLine("|             PISO 2             |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|________________________________|");
            Console.WriteLine("|             PISO 1             |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|               __               |");
            Console.WriteLine("|              |  |              |");
            Console.WriteLine("|______________|_ |______________|");

            Console.ResetColor();

            Console.WriteLine("¿Qué piso desea revisar: ?");
            Console.WriteLine("(1)Piso 1 (2)Piso 2 (3)Regresasr");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) 
                {
                    case 1:
                        Console.Clear();
                        Piso1();
                        break;
                    case 2:
                        Console.Clear();
                        Piso2();
                        break;
                    case 3: 
                        
                default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida, por favor seleccione 1, 2 o 3.");
                        break;
                }
        }   
        public void Piso1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("__________________________________");
            Console.WriteLine("|          PISO 1 - MAPA         |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|   [ ] Oficina 1                |");
            Console.WriteLine("|   [ ] Oficina 2                |");
            Console.WriteLine("|   [ ] Sala de Reuniones        |");
            Console.WriteLine("|   [ ] Baños                    |");
            Console.WriteLine("|________________________________|");
            Console.ResetColor();
        }
        public void Piso2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("__________________________________");
            Console.WriteLine("|          PISO 2 - MAPA         |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|   [ ] Laboratorio              |");
            Console.WriteLine("|   [ ] Biblioteca               |");
            Console.WriteLine("|   [ ] Cafetería                |");
            Console.WriteLine("|   [ ] Gimnasio                 |");
            Console.WriteLine("|________________________________|");
            Console.ResetColor();
        }

    }
}
