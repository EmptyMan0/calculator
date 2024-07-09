using System;
using System.Linq;
// Изучение основ программирования на C#: синтаксис, переменные, типы данных, операторы.
// Калькулятор должен делить умножать вычитать и слагать. 
//    Переводить в любую СИ
//    перед переводом нужно спросить в какой вводиться СИ
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rezult = 0;
            int rezultDiv = 0;
            string Perevod = "";

            Console.WriteLine($"Ввод только в ДЕСЯТИРИЧКЕ");
            Console.Write($"Введите первое значение: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите тип операции: ");
            var typeOperation = Console.ReadLine();

            Console.Write("Введите второе значение: ");
            var b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("в какую СИ перевести: ");
            var SI = Convert.ToInt32(Console.ReadLine());

            switch (typeOperation)
            {
                case "+":
                    rezult = a + b;
                    break;
                case "-":
                    rezult = a - b;
                    break;
                case "*":
                    rezult =  a * b;
                    break;
                case "/":
                    rezult = a / b;
                    break;
                    //default:
                    //    "неверно выбран тип операции";
                    //    break;
            }
            
            while (rezult > 0) 
            {
                Perevod += rezult % SI;
                rezult = rezult / SI;
            }

            char[] charArray = Perevod.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }

        private int Test(long a, long b, string typeOperation) 
        {
           
            return 0;
        }
    }
}
