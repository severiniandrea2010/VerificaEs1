double n1 = 0, n2 = 0, risultato = 0;
string operatore = "";
Console.WriteLine("Inserisci il primo numero");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserisci un operatore (+, -, *, /)");
operatore = Console.ReadLine();
if(operatore == "+")
{
    risultato = n1 + n2;
}
else if (operatore == "-")
{
    risultato = n1 - n2;
}
else if (operatore == "*")
{
    risultato = n1 * n2;
}
else if (operatore == "/")
{
    if(n2 < 0)
    {
        Console.WriteLine("Impossibile dividere per 0");
        risultato = 0;
    }
    else
    {
        risultato = n1 / n2;
    }
}
else
{
    Console.WriteLine("Hai inserito un operatore non valido");
}
Console.WriteLine($"Il risultato di questa operazione e' {risultato}");

