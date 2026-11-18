int quantidadeContas = 3;
Random random = new Random();

ContaBancaria[] contas = new ContaBancaria[quantidadeContas];

int GerarNumeroConta()
{
    int numero;
    bool existe;

    do
    {
        numero = random.Next(10, 100);
        existe = false;

        for (int i = 0; i < contas.Length; i++)
        {
            if (contas[i] != null && contas[i].Numero == numero)
            {
                existe = true;
                break;
            }
        }

    } while (existe);

    return numero;
}
void CriarContas()
{
    for (int i = 0; i < quantidadeContas; i++)
    {
        Console.WriteLine("Informe o Tipo de conta a ser criada:\n1-Conta Corrente \n2-Conta Poupança \n3-Conta Salário");

        int tipoConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o saldo da conta:");
        double saldo = double.Parse(Console.ReadLine());

        int numeroConta = GerarNumeroConta();

        if (tipoConta == 1)
        {
            ContaBancaria conta = new ContaCorrente(numeroConta, saldo);
            contas[i] = conta;
        }
        else if (tipoConta == 2)
        {
            ContaBancaria conta = new ContaPoupanca(numeroConta, saldo);
            contas[i] = conta;
        }
        else
        {
            ContaBancaria conta = new ContaSalario(numeroConta, saldo);
            contas[i] = conta;
        }
        Console.Clear();
    }
}

void ExibirContas()
{
    for(int i = 0;i < quantidadeContas;i++ )
    {
        Console.WriteLine(contas[i]); 
    }
}
void OperacoesConta()
{
    ContaBancaria conta = null;
    char outraAcao;

    Console.WriteLine("Informe o número da conta que quer realizar uma ação:");
    int numero = int.Parse(Console.ReadLine());

    for (int i = 0; i < contas.Length; i++)
    {
        if (contas[i].Numero == numero)
        {
            conta = contas[i];
            break;
        }
    }
    if (conta == null)
    {
        Console.WriteLine("Conta não encontrada!");
        return;
    }
    do
    {
        Console.WriteLine("Informe qual ação voce quer executar:\n1-Saque\n2-Depósito\n3-Transferência\n4-Pagamento");
        int operacao = int.Parse(Console.ReadLine());
        switch (operacao)
        {
            case 1:
                Console.WriteLine("Informe a quantia que deseja sacar:");
                double saque = double.Parse(Console.ReadLine());
                conta.Sacar(saque);
                break;

            case 2:
                Console.WriteLine("Informe a quantia que deseja depositar:");
                double deposito = double.Parse(Console.ReadLine());
                conta.Depositar(deposito);
                break;

            case 3:
                Console.WriteLine("Informe o número da conta de destino:");
                int numeroDestino = int.Parse(Console.ReadLine());

                ContaBancaria contaDestino = null;

                for (int i = 0; i < contas.Length; i++)
                {
                    if (contas[i].Numero == numeroDestino)
                    {
                        contaDestino = contas[i];
                        break;
                    }
                }
                if (contaDestino == null)
                {
                    Console.WriteLine("Conta não encontrada!");
                    return;
                }

                Console.WriteLine("Informe a quantia que deseja transferir:");
                double transferencia = double.Parse(Console.ReadLine());

                conta.Transferir(transferencia, contaDestino);
                break;

            case 4:
                Console.WriteLine("Informe a quantia que deseja pagar:");
                double pagamento = double.Parse(Console.ReadLine());
                conta.Pagar(pagamento);
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.Clear();
        ExibirContas();

        Console.WriteLine("Deseja realizar outra ação nesta mesma conta? (S/N)");
        outraAcao = char.Parse(Console.ReadLine().ToUpper());

    } while (outraAcao == 'S');
}

CriarContas();
ExibirContas();
OperacoesConta();
