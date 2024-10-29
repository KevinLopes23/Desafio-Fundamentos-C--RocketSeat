namespace Desafios_RocketSeat;

public class OperacoesComNumeros
{
    double numero1 = 2;
    double numero2 = 3;
    public void Operacoes()
    {
        double somar = numero1 + numero2;
        Console.WriteLine(somar);

        double subtracao = numero1 - numero2;
        Console.WriteLine(subtracao);

        double multiplicacao = numero1 * numero2;
        Console.WriteLine(multiplicacao);

        double divisao = numero1 / numero2;
        if (divisao == 0)
        {
            Console.WriteLine("Não vale");
            return;
        }
        else
        {
            Console.WriteLine(divisao);
        }

        double media = (numero1 + numero2) / 2;
        Console.WriteLine(media);

    }
}
