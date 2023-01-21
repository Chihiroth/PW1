class Program
{
    public static double CalculateTime(double distance, double speed)
    {
        return distance / speed;//рассчет времени преодоления расстояния
    }
    class Automobile//объявление класса для автомобиля
    {
        public string title;//Название автомобиля
        public double speed;//скорость

    }
    public static void anounce(string title, double speed)//метод вывода на экране названия автомобиля и скорости
    {
        Console.WriteLine("Название " + title);
        Console.WriteLine("Скорость " + speed);
    }
    static void Main(string[] args)
    {
        double distance = 300;//объявление расстояния
                              //объявление гонщиков
        string title1 = "Rambo";
        double speed1 = 25;
        string title2 = "Mist";
        double speed2 = 24;
        string title3 = "Hawkeye";
        double speed3 = 26;
        string title4 = "Noel";
        double speed4 = 22;
        anounce(title1, speed1);
        anounce(title2, speed2);
        anounce(title3, speed3);
        anounce(title4, speed4);
        Console.WriteLine();
        //соревнование
        double time1 = CalculateTime(distance, speed1);
        double time2 = CalculateTime(distance, speed2);
        double time3 = CalculateTime(distance, speed3);
        double time4 = CalculateTime(distance, speed4);
        double time; string title;
        if (time1 > time2) { time = time1; title = title1; }
        else { time = time2; title = title2; }
        if (time < time3) { time = time3; title = title3; }
        if (time < time4) { time = time4; title = title4; }
        //объявление победителя
        Console.WriteLine("Самым быстрым оказался " + title);
        Console.WriteLine("Его время = " + time);
        Console.ReadKey(true);
    }
}
