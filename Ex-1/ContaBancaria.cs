
public abstract class ContaBancaria
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

 
    public virtual void Depositar(double quantia)
    {
        Saldo += quantia;
    }

    public virtual void Sacar(double quantia)
    {
        Saldo -= quantia;
    }

    public virtual void Transferir(double quantia, ContaBancaria destino )
    {
        if (quantia > Saldo)
        {
            Console.WriteLine("Quantia a ser transferida maior do que o saldo disponível!");
        }
        else
        {
            Saldo -= quantia;
            destino.Depositar(quantia);
        }
    }

    public virtual void Pagar(double quantia)
    {
        Saldo -= quantia;
    }

    public override string ToString()
    {
        return $"O numero da conta é {Numero} e o saldo é de R$ {Saldo:F2} ";
    }
}

