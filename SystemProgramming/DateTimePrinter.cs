using System.Globalization;

namespace DatePrinterLibrary;
public class DateTimePrinter
{

    //1.4.3 Разработать DLL для работы с переменными типа DateTime.В библиотеку
    //включить методы, позволяющие по значению заданной переменной типа
    //DateTime отдельно печатать значение года, месяца и дня недели. В программе
    //предусмотреть печать результатов после выполнения любого метода DLL.
    //Значение переменных задавать в режиме диалога.

    private DateTime date;

    public DateTimePrinter(DateTime date)
    {
        this.date = date;
    }
    public void printDate()
    {
        Console.WriteLine(this.date.Date.ToString("dd.MM.yyyy"));
    }
    public void printYear()
    {
        Console.WriteLine(this.date.Year);
    }
    public void printMonth()
    {
        Console.WriteLine(this.date.Month);
    }
    public void printWeekDay()
    {
        Console.WriteLine(this.date.DayOfWeek);
    }
}

