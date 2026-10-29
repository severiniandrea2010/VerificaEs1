int n = 0, contaN = 0, ris = 0;
Console.WriteLine("Inserisci il numero di cui vuoi sapere la tabellina");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    ris = n * i;
    Console.WriteLine(ris);
    contaN = contaN + ris;
}
Console.WriteLine($"La somma di tutti i numeri è {contaN}");