using System.Globalization;

namespace Desafios_RocketSeat;

public class Data
{
    public void MostraData()
    {
        DateTime dataAtual = DateTime.Now;

        // Exibe as opções para o usuário
        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - Data com o mês por extenso");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;

            case 2:
                Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));
                break;

            case 3:
                Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm"));
                break;

            case 4:
                Console.WriteLine("Data com o mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
