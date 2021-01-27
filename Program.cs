using System;

namespace programming_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //FuncionNumeroPar();
            //FuncionPalabraMasLarga();
            //FuncionOrdenarNumeros();            
            //FuncionSaludar();
            //FuncionSumaDeNumeros();
            //FuncionSumaMultiplicar();
        }

        private static void FuncionNumeroPar()
        {
            Console.WriteLine("Escribe un numero:");
            var number = Console.ReadLine();

            if(!string.IsNullOrEmpty(number))
            {

                if(Convert.ToInt16(number)%2 == 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero no es par");
                }
            }
        }

        private static void FuncionPalabraMasLarga()
        {
            Console.WriteLine("Escribe la primera palabra:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Escribe la segunda palabra:");
            string word2 = Console.ReadLine();

            if(word1.Length > word2.Length)
            {
                Console.WriteLine("La palabra con mas caracteres es: " + word1);
            }
            else if(word1.Length == word2.Length)
            {
                Console.WriteLine("ambas palabras contienen la misma cantidad de letras");
            }
            else
            {
                Console.WriteLine("La palabra con mas caracteres es: " + word2);
            }
        }

        private static void FuncionOrdenarNumeros()
        {
            Console.WriteLine("Hola!! Cuantos numeros deseas ingresar para ordenar? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0 ; i < n ; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("Digite su primer numero");
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Digite su siguiente numero");
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("Ordenando Numeros...");

            for(int a =0; a < arr.Length;a++)
            {
                for(int b = 0; b < arr.Length-1-a;b++)
                {
                    if(arr[b] > arr[b+1])
                    {
                        (arr[b],arr[b+1]) = (arr[b+1],arr[b]);
                    }
                }
            }

            Console.WriteLine("Completado Numeros Ordenados");
            
            for(int it = 0 ; it < arr.Length;it++)
            {
                Console.WriteLine(arr[it]);
            }

        }

        public static void FuncionSaludar()
        {
            Console.WriteLine("Introduce tu nombre ..");
            string name = Console.ReadLine();

            Console.WriteLine("Ahora tu apellido..");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hola, " + name + "\n" + lastName);
        } 

        private static void FuncionSumaDeNumeros()
        {
            Console.WriteLine("Bienvenido a tu Programa de Suma de Numeros. \n Digita tu primer numero a sumar:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita tu segundo numero:");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine("Datos de entrada: " + num1 + " - " + num2);
            Console.WriteLine("Resultado: " + sum);
        }

        public static void FuncionSumaMultiplicar()
        {
            Console.WriteLine("Bienvenido !! Ingresa tu 1° numero a sumar");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora ingresa tu 2° numero a sumar");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Finalmente el ultimo numero por el cual sera multiplicado");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            int numSum = Num1 + Num2;
            int result = numSum * Num3; 

            Console.WriteLine("Datos de entrada:" + Num1 + ", " + Num2 + ", " + Num3 + "\n Resultado: " + result);
        }
    }
}
