namespace Tumakov_Kobyzeva_hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание");
            bool flag = true;
            short CountDay = 0;
            while (flag)
            {
                Console.WriteLine("Введите количество дней:");
                if (short.TryParse(Console.ReadLine(), out CountDay))
                {
                    if (CountDay > 0 && CountDay < 366)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Неверный диапозон");
                    }
                }
                else { Console.WriteLine("Неверно введены данные"); }
            }
            flag = true;
            int Year = 0;
            byte[] DayOfMonths;
            while (flag)
            {
                Console.WriteLine("Введите год:");
                if (int.TryParse(Console.ReadLine(), out Year))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                DayOfMonths = new byte[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            }
            else
            {
                DayOfMonths = new byte[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            }
            string[] Months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", 
                "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            for (int i = 0; i < 12; i++)
            {
                if (CountDay <= DayOfMonths[i])
                {
                    Console.WriteLine($"Месяц - {Months[i]}, день - {CountDay}");
                    break;
                }
                else
                {
                    CountDay = (short)(CountDay - DayOfMonths[i]);
                }
            }
        }
    }

}
