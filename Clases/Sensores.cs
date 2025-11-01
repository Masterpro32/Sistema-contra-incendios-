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
        List <int> Reg = new List<int>();
        public void CambionTemp()
        {
            int temperatura = TempPreterminada;
            int cont = 1;
            while (true)
            {
                int valorCambio = r.Next(1,5);
                temperatura = temperatura + valorCambio;
                Console.SetCursorPosition(60, 3);
                Console.WriteLine($"TEMPERATURA ACTUAL: {temperatura}°");
                Reg.Add(temperatura);
                cont++;
                Thread.Sleep(1000);
                Console.SetCursorPosition(60, 3);
                if (temperatura > 60)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Beep(700, 1200);
                    Console.Beep(700, 1200);
                    Console.SetCursorPosition(60, 3);//(x,y) y cuentan desde el 0
                    Console.WriteLine($"¡LA TEMPERATURA EXCEDIÓ LOS LÍMITES {temperatura}°");
                    Console.SetCursorPosition(60, 4);
                    Console.WriteLine("Evacuar inmediatamente la zona");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    break;
                }
            }
        }
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
    }
}
