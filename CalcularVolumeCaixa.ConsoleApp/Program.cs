namespace CalcularVolumeCaixa.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)


        {


            int resultado = 0;
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Olá, vamos calcular o volume da sua caixa?");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Para começar, irei precisar das medidas de sua caixa:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("digite a medida do comprimento da caixa ");

            int comprimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2 - digite a medida do largura da caixa");

            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("2 - digite a medida do largura da caixa");

            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------");


            
            resultado = comprimento * largura * altura;
            

            Console.WriteLine("Obrigado pelos dados,o volume da sua caixa é : " + resultado);

        }
    }
}
