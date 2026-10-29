Random rnd = new Random();
int numeroCasuale = rnd.Next(1, 101);
int numeroI = 0, tentativi = 0;
Console.WriteLine(numeroCasuale);
do
{
  Console.WriteLine("Inserisci un numero");
  numeroI=Convert.ToInt32(Console.ReadLine());
  if(numeroI!=numeroCasuale)
  {
        tentativi++;
        Console.WriteLine("Sbagliato, Riprova");
  }
}while (numeroCasuale != numeroI);
Console.WriteLine($"Hai indovinato, hai impiegato {tentativi} tentativi");