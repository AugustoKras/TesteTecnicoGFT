using System;

    public class Program
    {
        public static void Main()
        {
            string input;
            int input_number;
            int random_number;

            System.Random random = new System.Random();
            random_number  = random.Next(11);

            System.Console.WriteLine("Insira um número: ");
            input = Console.ReadLine();
            input_number = Convert.ToInt32(input);

            while(input_number != random_number){
            System.Console.WriteLine("Número errado, tente novamente: ");
            input = Console.ReadLine();
            input_number = Convert.ToInt32(input);
            }

        System.Console.WriteLine("Acertou! Resposta: {0}", random_number);
        }
    }
