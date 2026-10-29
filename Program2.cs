float temp = 0;
Console.WriteLine("Inserisci la temperatura attuale in gradi celsius");
temp = float.Parse(Console.ReadLine());
switch (temp)
{
    case < 0:
        Console.WriteLine("Fa molto freddo");
        break;

    case < 18:
        Console.WriteLine("Fa fresco");
        break;

    case < 30:
        Console.WriteLine("Il clima e' mite");
        break;

    case > 30:
        Console.WriteLine("Fa molto caldo");
        break;
}