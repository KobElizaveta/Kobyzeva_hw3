using Latypova_Kobyzeva_hw3.Enum;

namespace Latypova_Kobyzeva_hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            bool flag1 = true;
            string Sequence = "";
            while (flag1)
            {
                Console.WriteLine("Введите последовательность чисел");
                Sequence = Console.ReadLine();
                if (int.TryParse(Sequence, out int _) && Sequence.Length > 1)
                {
                    flag1 = false;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
            for (int i = 1; i < Sequence.Length; i++)
            {
                if (!(Sequence[i - 1] < Sequence[i]))
                {
                    Console.WriteLine($"Последовательность не является упорядоченной.\n" +
                        $"Номер числа, что нарушает последовательность:{i + 1}");
                    break;
                }
                else if (i + 1 == Sequence.Length)
                {
                    Console.WriteLine($"Последовательность является упорядоченной по возрастанию");
                }
                else
                {
                    continue;
                }
            }
            
            Console.WriteLine("Задание 2");
            bool flag2 = true;
            byte NumberCard;
            string nameCard;
            while (flag2)
            {
                try
                {
                    Console.WriteLine("Введите номер карты");
                    NumberCard = byte.Parse(Console.ReadLine());
                    if( !NameCard.IsDefined(typeof(NameCard), ((NameCard)NumberCard).ToString()))
                    {
                        throw new Exception();
                    }
                    nameCard = ((NameCard)NumberCard).ToString();
                    Console.WriteLine($"Навзание: {nameCard}");
                    flag2 = false;

                }
                catch 
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку:");
            string StringInput = Console.ReadLine().ToLower();
            string[,] InToOutput =
                {{ "Jabronl", "Patron Tequlla" },
                { "School Counselor", "Anything with Alcohol" },
                {"Programmer", "Hipster Craft Beer" },
                {"Bike Gang Member", "Moonshine" },
                {"Politician", "Your tax dollars" },
                {"Rapper", "Cristal" },
                {"another", "Beer" }};
            for (int i = 0; i < InToOutput.GetLength(0); i++)
            {
                if (StringInput == InToOutput[i, 0].ToLower())
                {
                    Console.WriteLine(InToOutput[i, 1]);
                    break;
                }
                else if (i + 1 == InToOutput.GetLength(0))
                {
                    Console.WriteLine(InToOutput[i, 1]);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Задание 4");
            bool flag4 = true;
            byte InputDay;
            while (flag4)
            {
                Console.WriteLine("Введите число дня недели");
                if (byte.TryParse(Console.ReadLine(), out InputDay) && InputDay <= 7 && InputDay >= 1)
                {
                    string NameDayInput = ((WeekDay)InputDay).ToString();
                    Console.WriteLine($"День недели: {NameDayInput}");
                    flag4 = false;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }

            Console.WriteLine("Задание 5");
            byte CountDoll = 0;
            string[] ListOfSubjects = {"Hello Kitty", "Telephone", "Barbie doll", 
                "Water bottle", "Keys", "Barbie doll", "Sandwich"};
            foreach(string Subject in ListOfSubjects)
            {
                if(Subject == "Hello Kitty" || Subject == "Barbie doll")
                {
                    ++CountDoll;
                }
            }
            Console.WriteLine($"Количество кукол: {CountDoll}");
        }
    }
}
