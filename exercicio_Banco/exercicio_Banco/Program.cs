using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Banco {
    class Program {
        static void Main(string[] args) {

            Conta conta;
            double valorConta = 0;

            Console.WriteLine("Digite o numero da conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            string opcao = Console.ReadLine();

            if (opcao == "s") {
                Console.WriteLine("Digite o valor do depósito inicial: ");
                valorConta = Convert.ToDouble(Console.ReadLine());
            }

            conta = new Conta(numeroConta, nome, valorConta);
            Console.WriteLine("======================================");
            Console.WriteLine(" Conta criada: " + conta.ToString());
            Console.WriteLine("======================================");

            Console.WriteLine("Digite um valor para depositar na conta");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.DepositandoValor(deposito);

            Console.WriteLine("======================================");
            Console.WriteLine(" Conta atualizada: " + conta.ToString());
            Console.WriteLine("======================================");


            Console.WriteLine("Digite um valor para sacar da conta");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.SacandoValor(saque);

            Console.WriteLine("======================================");
            Console.WriteLine(" Conta atualizada: " + conta.ToString());
            Console.WriteLine("======================================");


            Console.ReadKey();

        }
    }
}
