public class ContaCorrente : ContaBancaria
{
    public double Limite;

    public ContaCorrente(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
        CalcularLimite();
    }

    public void CalcularLimite()
    {
        if (Saldo > 0)
        {
            Limite = Saldo * 3;
        }
        else
        {
            Limite = 0;
        }
    }

    public override void Depositar(double quantia)
    {
        Saldo += quantia;
        CalcularLimite();
    }

    public override void Sacar(double quantia)
    {
        if (quantia > Saldo + Limite)
        {
            Console.WriteLine("Quantia a ser sacada maior do que o disponível de saldo e limite!");
        }
        else
        {
            Saldo -= quantia;
            CalcularLimite();
        }
    }

    public override void Transferir(double quantia, ContaBancaria destino)
    {
        if (quantia > Saldo + Limite)
        {
            Console.WriteLine("Quantia a ser transferida maior do que o disponível de saldo e limite!");
        }
        else
        {
            Saldo -= quantia;
            destino.Depositar(quantia);
            CalcularLimite();
        }
    }

    public override void Pagar(double quantia)
    {
        if (quantia > Saldo + Limite)
        {
            Console.WriteLine("Quantia a ser paga maior do que o disponível de saldo e limite!");
        }
        else
        {
            Saldo -= quantia;
            CalcularLimite();
        }
    }
}

