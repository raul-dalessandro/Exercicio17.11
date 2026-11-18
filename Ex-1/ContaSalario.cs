using System.ComponentModel;

public class ContaSalario :  ContaBancaria
{
    public ContaSalario(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }
    public override void Sacar(double quantia)
    {
        if (quantia > Saldo)
        {
            Console.WriteLine("Quantia a ser sacada maior do que o saldo disponnível!");
        }
        else
        {
            Saldo -= quantia;
        }
    }
}

