using Dio.Series.Class;
using Dio.Series.Enums;
using Dio.Series.Repositories;

SerieRepository repository = new();
Main();

void Main()
{
    string userOption = GetUserOption();

    while (userOption.ToUpper() != "X")
    {
        switch (userOption)
        {
            case "1":
                ListSeries();
                break;
            case "2":
                InsertSerie();
                break;
            case "3":
                Update();
                break;
            case "4":
                Delete();
                break;
            case "5":
                ViewSerie();
                break;
            case "C":
                Console.Clear();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        userOption = GetUserOption();
    }
    Console.WriteLine("Thanks for use our services!!!");
    Console.ReadLine();
}



#region "Methods"
void ViewSerie()
{
    Console.WriteLine("Type the ID of serie: ");
    int _idSerie = int.Parse(Console.ReadLine());

    var serie = repository.GetById(_idSerie);
    Console.WriteLine(serie);
}

void Update()
{
    Console.WriteLine("Update Serie");
    Console.WriteLine();
    Console.WriteLine("---------------------");
    Console.WriteLine();
    Console.WriteLine("Type the ID of serie: ");
    int _idSerie = int.Parse(Console.ReadLine());

    foreach (int genus in Enum.GetValues(typeof(Genus)))
    {
        Console.WriteLine($"{genus} - {Enum.GetName(typeof(Genus), genus)}");
    }

    Console.Write("Type the genus between the options above: ");
    int _genus = int.Parse(Console.ReadLine());

    Console.Write("Type the title of serie: ");
    string _tille = Console.ReadLine();

    Console.Write("Type the release year of serie: ");
    int _year = int.Parse(Console.ReadLine());

    Console.Write("Type the description of serie: ");
    string _description = Console.ReadLine();

    Serie newSerie = new(id: _idSerie,
                         genus: (Genus)_genus,
                         title: _tille,
                         year: _year,
                         description: _description);

    repository.Update(_idSerie, newSerie);
}

void Delete()
{
    Console.WriteLine("Type the ID of serie: ");
    int _idSerie = int.Parse(Console.ReadLine());

    repository.Delete(_idSerie);
}

void InsertSerie()
{
    Console.WriteLine("Insert New Serie");

    foreach (int genus in Enum.GetValues(typeof(Genus)))
    {
        Console.WriteLine($"{genus} - {Enum.GetName(typeof(Genus), genus)}");
    }

    Console.Write("Type the genus between the options above: ");
    int _genus = int.Parse(Console.ReadLine());

    Console.Write("Type the title of serie: ");
    string _tille = Console.ReadLine();

    Console.Write("Type the release year of serie: ");
    int _year = int.Parse(Console.ReadLine());

    Console.Write("Type the description of serie: ");
    string _description = Console.ReadLine();

    Serie newSerie = new(id: repository.NextId(),
                         genus: (Genus)_genus,
                         title: _tille,
                         year: _year,
                         description: _description);

    repository.Insert(newSerie);
}

void ListSeries()
{
    Console.WriteLine("List Series");

    var list = repository.List();

    if (list.Count == 0)
    {
        Console.WriteLine("None serie registered");
        return;
    }
    foreach (var serie in list)
    {
        var excluded = serie.GetExclude();
        Console.WriteLine($"ID {serie.GetId()}: - {serie.GetTitle()} - {(excluded ? "*Excluded*" : "Active")}");
    }
}

static string GetUserOption()
{
    Console.WriteLine();
    Console.WriteLine("Dio Series at your service!");
    Console.WriteLine("Insert the desired option:");
    Console.WriteLine();

    Console.WriteLine("1 - List Series");
    Console.WriteLine("2 - Insert New Serie");
    Console.WriteLine("3 - Update Serie");
    Console.WriteLine("4 - Exclude Serie");
    Console.WriteLine("5 - View Serie");
    Console.WriteLine("C - Clean Screen");
    Console.WriteLine("X - Exit");

    string userOption = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return userOption;
}
#endregion