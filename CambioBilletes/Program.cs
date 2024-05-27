using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioBilletes
{
    class Program
    {
        static void Main(string[] args)
        {
            //billetes 
            Console.WriteLine("Ingresa el billete");
            int valor;
            valor = Convert.ToInt32(Console.ReadLine());

            List<string> devuelta = new List<string>();

            int division = 0;
            int contador = 0;
            int restante = 0;


            if (valor > 2000)
            {
                division = valor / 2000;
                devuelta.Add(division + " DE 2000");
                restante = valor - (2000 * division);
                contador++;
            }
            if (valor > 1000)
            {
                if (contador > 0)
                {
                    division = restante / 1000;
                    restante = restante - (1000 * division);
                }
                else
                {
                    division = valor / 1000;
                    restante = valor - (1000 * division);
                }

                devuelta.Add(division + " DE 1000");
                contador++;
            }
            if (valor > 500)
            {
                if (contador > 0)
                {
                    division = restante / 500;
                    restante = restante - (500 * division);
                }
                else
                {
                    division = valor / 500;
                    restante = valor - (500 * division);
                }

                devuelta.Add(division + " DE 500");
                contador++;
            }

            if (valor > 200)
            {
                if (contador > 0)
                {
                    division = restante / 200;
                    restante = restante - (200 * division);
                }
                else
                {
                    division = valor / 200;
                    restante = valor - (200 * division);
                }

                devuelta.Add(division + " DE 200");
                contador++;
            }

            if (valor > 100)
            {
                if (contador > 0)
                {
                    division = restante / 100;
                    restante = restante - (100 * division);
                }
                else
                {
                    division = valor / 100;
                    restante = valor - (100 * division);
                }

                devuelta.Add(division + " DE 100");
                contador++;
            }
            if (valor > 50)
            {
                if (contador > 0)
                {
                    division = restante / 50;
                    restante = restante - (50 * division);
                }
                else
                {
                    division = valor / 50;
                    restante = valor - (50 * division);
                }

                devuelta.Add(division + " DE 50");
                contador++;
            }
            if (valor > 25)
            {
                if (contador > 0)
                {
                    division = restante / 25;
                    restante = restante - (25 * division);
                }
                else
                {
                    division = valor / 25;
                    restante = valor - (25 * division);
                }

                devuelta.Add(division + " DE 15");
                contador++;
            }

            if (valor > 10)
            {
                if (contador > 0)
                {
                    division = restante / 10;
                    restante = restante - (10 * division);
                }
                else
                {
                    division = valor / 10;
                    restante = valor - (10 * division);
                }

                devuelta.Add(division + " DE 10");
                contador++;
            }

            if (valor > 5)
            {
                if (contador > 0)
                {
                    division = restante / 5;
                    restante = restante - (5 * division);
                }
                else
                {
                    division = valor / 5;
                    restante = valor - (5 * division);
                }

                devuelta.Add(division + " DE 5");
                contador++;
            }

            if (valor > 1)
            {
                if (contador > 0)
                {
                    division = restante / 1;
                    restante = restante - (1 * division);
                }
                else
                {
                    division = valor / 1;
                    restante = valor - (1 * division);
                }

                devuelta.Add(division + " DE 1");
                contador++;
            }

            foreach (var item in devuelta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
