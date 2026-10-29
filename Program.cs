int eta = 0;
const int MAGG = 18;
Console.WriteLine("Inserisci la tua eta'");
eta = Convert.ToInt32(Console.ReadLine());
if (eta < 0)
{
    Console.WriteLine("Hai inserito un valore troppo basso");
}
else if(eta >= MAGG)
{
    Console.WriteLine("Sei maggiorenne e puoi votare");
}
else
{
    Console.WriteLine("Sei minorenne, non puoi ancora votare ");
}
