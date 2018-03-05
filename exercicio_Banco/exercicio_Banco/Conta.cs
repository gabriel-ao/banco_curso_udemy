using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Banco {
    class Conta {

        public int numeroConta { get; private set; }
        public string nomeTitular { get; private set; }
        public double valorConta { get; private set; }
        int taxa = 5;

        public Conta(int numeroConta, string nomeTitular, double valorConta) {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.valorConta = valorConta;
        }

        public double DepositandoValor(double novaEntrada) {
            return valorConta += novaEntrada;
        }

        public double SacandoValor(double novaSaida) {
            if (novaSaida < valorConta) {
                return valorConta -= (taxa + novaSaida);
            } else {
                return valorConta;
            }
        }

        public override string ToString() {
            return " Conta: " + numeroConta
                + " Titular: " + nomeTitular
                + " Saldo: " + valorConta
                ;
        }
    }
}
