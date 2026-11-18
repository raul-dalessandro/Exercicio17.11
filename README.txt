Classes Abstratas e Herança
1) Sistema de contas bancárias

Crie uma classe abstrata ContaBancaria com as seguintes propriedades:
- Número da conta;
- Saldo.
A classe ContaBancaria deve possuir os seguintes métodos:
- Depositar(): adiciona um valor ao saldo;
- Sacar(): retira um valor do saldo;
- Transferir(): transfere um valor para outra conta;
- Pagar(): realiza um pagamento, descontando o valor do saldo.
Existem três tipos de conta, que devem herdar da classe ContaBancaria:

Conta Corrente:
- Possui uma propriedade chamada Limite, definida automaticamente como o triplo do saldo atual;
- Caso o saldo esteja negativo, o limite deve ser zerado;
- O valor máximo que pode ser gasto é a soma do saldo com o limite disponível naquele momento.
Conta Poupança:

- Toda vez que realizar um saque, deve ser descontada uma taxa de 5% sobre o valor sacado.

Conta Salário:

- Não possui limite para realizar saques, podendo utilizar somente o saldo disponível.

Programa principal:

Desenvolva um programa que gerencie três contas bancárias.

O programa deve perguntar ao usuário qual tipo de conta deseja criar para cada uma das três contas.

O usuário deverá criar uma conta corrente, uma conta poupança e uma conta salário, sem necessidade de validar se ele escolheu tipos diferentes.

Após criar as três contas, armazene os objetos em um vetor e permita que o programa trabalhe com as três contas cadastradas.