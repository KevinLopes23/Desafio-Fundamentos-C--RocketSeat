namespace Desafios_RocketSeat;

public class NomeCompleto
{
   public void ConcatenaNomeCompleto()
    {
        Console.WriteLine("Digite seu Nome");
        string Nome = Console.ReadLine();
        Console.WriteLine("Digite seu Sobrenome");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {Nome} {sobrenome}!");
    }

}   
