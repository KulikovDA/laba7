//средний уровень 25
try
{
    Console.Write("Введите количество футболистов:");
    int n = int.Parse(Console.ReadLine());
    Man[] mans = new Man[n];
    for (int i = 0; i < n; i++)
    {
        mans[i] = new Man();
        Console.Write("Фамилия:");
        mans[i].fam = Console.ReadLine();
        Console.Write("Амплуа:");
        mans[i].amplua = Console.ReadLine();
        Console.Write("Количество игр:");
        mans[i].games = int.Parse( Console.ReadLine());
        Console.Write("Дата рождения:");
        mans[i].Year = int.Parse(Console.ReadLine());
        Console.Write("Количество забитых мячей:");
        mans[i].skok = int.Parse(Console.ReadLine());
        Console.Write("Место рождения:");
        mans[i].mest = Console.ReadLine();
    }
    foreach (Man man in mans)
    {
        if (man.games%man.skok<=0.4 )
        {
            Console.WriteLine(man.fam);
            Console.WriteLine(man.amplua);
            Console.WriteLine(man.games);
            Console.WriteLine(man.Year);
            Console.WriteLine(man.skok);
            Console.WriteLine(man.mest);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Man
{
    public string fam;
    public string amplua;
    public int games;
    public int Year;
    public int skok;
    public string mest;
}