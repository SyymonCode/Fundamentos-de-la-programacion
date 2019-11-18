using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adiviname_Esta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Adivinator2000, mediante una serie de preguntas tendras que adivinar el numero entre 0 y 10");
            Random R = new Random();
            int Numero = R.Next(0, 10);
            int Adivinador = 20;
            while (Adivinador != Numero)
            {
                Console.WriteLine("Ahora escribe un numero, si el numero es menor o mayor que el numero a adivinar se te indicará");
                Adivinador=Convert.ToInt32(Console.ReadLine( ));
                if(Adivinador<Numero)
                {
                    Console.WriteLine("El numero es mayor que el tuyo. ¡Intentalo de nuevo!");

                }
                else
                {
                     if(Adivinador>Numero)
                    {
                        Console.WriteLine("El numero es menor que el tuyo. ¡Intentalo de nuevo!");
                    }
                    else
                    {
                        Console.WriteLine("¡Enhorabuena, has acertado el numero!");
                    }
                }
                
            }
            Console.ReadLine();

        }
    }
}
