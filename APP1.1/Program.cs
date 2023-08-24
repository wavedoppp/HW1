namespace APP1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать. Введите свои Имя и фамилию: ");
            string fullName = Console.ReadLine();

            Console.WriteLine($"Привет, {fullName}!");
            Console.WriteLine($"Введите свою дату рождения!");
            Console.WriteLine();
            Console.WriteLine($"День:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine($"Месяц:");
            int month = int.Parse(Console.ReadLine());

            Console.Write($"{fullName} ");
            Console.WriteLine() ;
            int min = month - day ;
            int sum = month + day;
            int del = month % day;
            int um = month * day;
            Console.Write($"Разница: {min}");
            Console.WriteLine() ;
            Console.Write($"Сумма: {sum}");
            Console.WriteLine();
            Console.Write($"Остаток: {del}");
            Console.WriteLine();
            Console.Write($"Умножено: {um}");
            Console.WriteLine();




            Console.ReadLine() ;
        }
    }
}