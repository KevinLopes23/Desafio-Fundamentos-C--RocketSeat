using Desafios_RocketSeat;

class Program
{
    static void Main()
    {
        MensagemPersonalizada mensagemPersonalizada = new MensagemPersonalizada();
        mensagemPersonalizada.Mensagem();

        OperacoesComNumeros operacoesComNumeros = new OperacoesComNumeros();

        operacoesComNumeros.Operacoes();

        ContaCaracteres contaCaracteres = new ContaCaracteres();

        contaCaracteres.ContaLetras();

        VerificacaoDePlaca verifcaplaca = new VerificacaoDePlaca();

        verifcaplaca.VerificaPlaca();

        Data data = new Data();

        data.MostraData();
    }

}
