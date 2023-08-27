namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* string nome1, nome2, nome3, nome4, auxiliar;

             Console.WriteLine("digite o nome 1");
             nome1 = Console.ReadLine();

             Console.WriteLine("digite o nome 2");
             nome2 = Console.ReadLine();

             Console.WriteLine("digite o nome 3");
             nome3 = Console.ReadLine();

             Console.WriteLine("digite o nome 4"); 
             nome4 = Console.ReadLine();

             auxiliar = nome1;
             nome1 = nome4;
             nome4 = auxiliar;
             auxiliar = nome2;
             nome2 = nome3;
             nome3 = auxiliar;


             Console.WriteLine();
             Console.WriteLine("nomes invertidos");
             Console.WriteLine(nome1);
             Console.WriteLine(nome2);
             Console.WriteLine(nome3);
             Console.WriteLine(nome4);
             Console.ReadKey();
            


            bool resultado = 50 == 50;
            bool resultado2 = 100 < 99;
            Console.WriteLine(resultado && resultado2);
            Console.ReadKey();
            */

            //Conversor de Temperatura


            double c, f, k;

            Console.WriteLine("CONVERSOR DE TEMPERATURA");
            Console.WriteLine("insira a temperatura em Celcius");
            
            c = double.Parse (Console.ReadLine());
            Console.WriteLine("___");

            f = (c * 9 / 5) + 32;

            k = c + 273.15;

            Console.WriteLine("a temperatura em c é: " +  c);
            Console.WriteLine("a temperatura em f é: " +  f);
            Console.WriteLine("a temperatura em k é: " + k);





        }
    }
}