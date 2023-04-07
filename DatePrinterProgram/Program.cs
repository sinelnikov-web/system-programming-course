using System.Globalization;
using DatePrinterLibrary;

namespace DatePrinterProgram;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату в формате DD.MM.YYYY: ");
        string dateString = Console.ReadLine();
        DateTime date;
        DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat;
        DateTime.TryParse(dateString, dtfi, out date);
        DateTimePrinter printer = new DateTimePrinter(date);
        while (true)
        {
            Console.WriteLine("1 - Задать новую дату");
            Console.WriteLine("2 - Напечатать дату");
            Console.WriteLine("3 - Напечатать год");
            Console.WriteLine("4 - Напечатать месяц");
            Console.WriteLine("5 - Напечатать день недели");
            Console.WriteLine("6 - Завершить программу");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    {
                        Console.WriteLine("Введите дату в формате DD.MM.YYYY: ");
                        dateString = Console.ReadLine();
                        DateTime.TryParse(dateString, dtfi, out date);
                        printer = new DateTimePrinter(date);
                        break;
                    }
                case "2":
                    {
                        printer.printDate();
                        break;
                    }
                case "3":
                    {
                        printer.printYear();
                        break;
                    }
                case "4":
                    {
                        printer.printMonth();
                        break;
                    }
                case "5":
                    {
                        printer.printWeekDay();
                        break;
                    }
                case "6":
                    {
                        return;
                    }
            }
           
        }
    }
}