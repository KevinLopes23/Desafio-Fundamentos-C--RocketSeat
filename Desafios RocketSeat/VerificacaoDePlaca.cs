namespace Desafios_RocketSeat;

public class VerificacaoDePlaca
{

    public Boolean VerificaPlaca()
    {
        Console.WriteLine("Digite Sua placa");
         string placa = Console.ReadLine();
        if (placa.Length == 7 && char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]) && char.IsNumber(placa[3]) && char.IsNumber(placa[4]) && char.IsNumber(placa[5]) && char.IsNumber(placa[6])){
            Console.WriteLine("Placa valida");
            return true;
        }
        else
        {
            Console.WriteLine("Placa Invalida");
            return false;
        }
    }
}
