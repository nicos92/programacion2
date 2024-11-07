using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alexis
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nombre = new List<string>();

            string[,] arrayNombre = new string[3, 3];
            Console.WriteLine("ingresa los nombres");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayNombre[i, j] = Console.ReadLine();
                    //Console.WriteLine(arrayNombre[i,j]);
                    nombre.Add(arrayNombre[i, j]);
                }
            }

            nombre.Sort();

            foreach (string pepe in nombre)
            {
                Console.WriteLine("lista nombre: " + pepe);
            }
            Console.ReadKey();
        }
    }
}
