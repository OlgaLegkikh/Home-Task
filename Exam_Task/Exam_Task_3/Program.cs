// See https://aka.ms/new-console-template for more information
DateTime date = new DateTime();
date = DateTime.Now;
Console.WriteLine(date.DaysFromWorldBegan());

public static class DateTimeExtension
{
    public static string DaysFromWorldBegan(this DateTime dt)
    {
        return $"День ‘{dt.Day}’ месяца ‘{dt.Month}’ года ‘{ dt.Year+ 5501}’ от сотворения мира.";
    }
}