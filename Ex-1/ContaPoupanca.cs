

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public override void Sacar(double quantia)
    {
        double total = quantia * 1.05;
        if (total > Saldo)
        {
            Console.WriteLine("Quantia a ser sacada maior do que o saldo disponível!");
        }
        else
        {
            Saldo = Saldo - total;
        }
    }
}


