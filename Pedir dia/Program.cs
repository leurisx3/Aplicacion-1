using System;

namespace Pedir_dia
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Dame un dia: ");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes": Console.WriteLine("Haz elegido el lunes"); break;
                case "martes": Console.WriteLine("Haz elegido el martes"); break;
                case "miercoles": Console.WriteLine("Haz elegido el miercoles"); break;
                case "jueves": Console.WriteLine("Haz elegido el jueves"); break;
                case "viernes": Console.WriteLine("Haz elegido el viernes"); break;
                case "sabado": Console.WriteLine("Haz elegido el sabado"); break;
                case "domingo": Console.WriteLine("Haz elegido el domingo"); break;
                default: Console.WriteLine("No es un dia"); break;

            }
        }
    }
}
