using System.IO.Pipes;

namespace macanHuesos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Я говрою макан, вы говорите хуесос";
            Console.WriteLine(stroka);
            while (true)
            {
               Console.WriteLine( "Макан ");
                string answer = Console.ReadLine();
                if(answer.ToLower() != "хуесос" || answer.ToLower() != "Xуесос")
                {
                    Console.WriteLine("Почему Макан не хуесос?");
                    break;
                }
               
            }
            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadKey();
        }
    }
}
