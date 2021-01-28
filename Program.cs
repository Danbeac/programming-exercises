using System;

namespace programming_exercises
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Part 1
            //FuncionNumeroPar();
            //FuncionPalabraMasLarga();
            //FuncionOrdenarNumeros();            
            //FuncionSaludar();
            //FuncionSumaDeNumeros();
            //FuncionSumaMultiplicar();

            //Part 2
            //FuncionRestaDePizzas();
            //FuncionEdadPastAndFuture();
            //FuncionWordAlRevez();
            //FuncionBackword();
            //CalculadorDeDias();
            //billRestaurant();
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

        private static void FuncionRestaDePizzas()
        {
            Console.WriteLine("Cuantas rebanadas de pizza trajiste !?");
            int rebanadasPizza =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En este caso X = " + rebanadasPizza + "\n Ahora dime cuantas se han comido ?");
            int rebanadasComidas =Convert.ToInt32(Console.ReadLine());

            int rebanadasRestantes = rebanadasPizza - rebanadasComidas;
            Console.WriteLine("Ahora resulta que Y = " + rebanadasComidas + "\n ..por ende Z = " + rebanadasRestantes + "\n Lo que equivale a la cantidad de pizzas que aun tienes posibilidades de comer ;)");
        }

        private static void FuncionEdadPastAndFuture()
        {
            Console.WriteLine("Hola !! \n Soy Anacleta y puedo saber tu futuro y tu pasado..");
            Console.WriteLine("Ahora que ya me conoces.. dime tu nombre y tu edad separada por una coma :D");
            string nameAndAge = Console.ReadLine();
            string[] values = nameAndAge.Split(",");

            string name = values[0];
            string Age = values[1];

            int age = Convert.ToInt32(Age);

            int pastAge = age - 1;
            int futureAge = age + 1;

            Console.WriteLine(name + " el año pasado tenías "+ pastAge +" años y el próximo año cumplirás " + futureAge + " años.");
        }

        private static void FuncionWordAlRevez()
        {
            var backwardsword = "";
            var amountLetters = 0;
            int itinerador = 0;

            Console.WriteLine("Bienvenido !! \n Escribe la palabra que quieras para volverla al revez:");
            string word = Console.ReadLine();
            amountLetters = word.Length;

            char[] arr = new char[amountLetters];
            
            //Llena el array con las letras de la palabra
            foreach(char letter in word)
            {
                arr[itinerador] = Convert.ToChar(letter);
                itinerador++;
            }

            //Transcribe la palabra al revez
            for(int i = amountLetters-1; i >= 0; i--)
            {
                backwardsword += arr[i];
            }

            Console.WriteLine("Palabra al revez:");
            Console.WriteLine(backwardsword);
        }

        private static void FuncionBackword()
        {
            var backwardsword = "";
            var size = 0;

            Console.WriteLine("Bienvenido !! \n Escribe la palabra que quieras para volverla al revez:");
            string word = Console.ReadLine();
            size = word.Length;
            

            //Transcribe la palabra al revez
            for(int i = size-1; i >= 0; i--)
            {
                backwardsword += word[i];
            }

            Console.WriteLine("Palabra al revez:");
            Console.WriteLine(backwardsword);
        }

        public static void CalculadorDeDias()
        {
            int dias = 0;
            int hoursValue = 0;
            int minutesValue = 0;
            int secondsValue = 0;
            int hoursInADay = 24;
            int minutesInAHour = 60;
            int secondsInAMinute = 60;

            Console.WriteLine("Escribe el numero de dias que quieres calcular:");
            dias = Convert.ToInt32(Console.ReadLine());

            //Se calculan horas x dias
             hoursValue = dias * hoursInADay;

            //Se calculan minutos x dias
            minutesValue = dias * (hoursInADay * minutesInAHour);

            //Se calculan minutos x dias
            secondsValue = dias * ((hoursInADay * minutesInAHour) * secondsInAMinute);

            Console.WriteLine("Estos son los resultados: \n");
            Console.WriteLine(" Horas/Hours: \n "+ hoursValue + " \n Minutos/Minutes: \n " + minutesValue + " \n Segundos/Seconds: \n " + secondsValue);
        }

        public static void billRestaurant()
        {
            Console.WriteLine("Restaurante la perrera del chavo \n Indicanos cuanto es el total a pagar:");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indicanos entre cuantas personas se dividará la cuenta:");
            int people = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Deseas dejar propina? \n Marca true si lo deseas o false en caso contrario");
            bool flagPropina = Convert.ToBoolean(Console.ReadLine());   
            int totalperPerson = total / people;
            int totalBill = 0;

            if(flagPropina)
            {
                Console.WriteLine("Indicanos el valor en porcentaje % de tu propina:");
                int porcentajePropina = Convert.ToInt32(Console.ReadLine());

                int propina = total * porcentajePropina / 100;
                totalBill = total + propina;

                totalperPerson = totalBill / people;
            }


            Console.WriteLine("======================================================================");
            Console.WriteLine("Resultado Bill Perrera el Chavo:  ");
            Console.WriteLine("Total: " + total);
            if(flagPropina){
                Console.WriteLine("Total + Propina: " + totalBill);
            }

            Console.WriteLine("Cuenta dividida entre " + people + " personas");
            Console.WriteLine("Valor por persona: ");
            Console.WriteLine("$" + totalperPerson);
            Console.WriteLine("======================================================================");

        } 
    }
}
