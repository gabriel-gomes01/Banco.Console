namespace Bank.Dio
{
    class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
            TipoConta = tipoConta;
        }

        public bool Sacar(double Valorsaque)
        {
            //Validação do Saldo para saque
            if(this.Saldo - Valorsaque < (this.Credito * -1))
            {
                System.Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= Valorsaque;
            System.Console.WriteLine("Saldo atual da conta {0} é {1}", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double Deposito)
        {
            this.Saldo += Deposito;
            System.Console.WriteLine("Saldo atual da conta {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }
        public override string ToString()
        {
            
            return "Tipo Conta: " + this.TipoConta +
                    "\nSaldo: " + this.Saldo +
                    "\nNome: " + this.Nome +
                    "\nCredito: " + this.Credito;

        }
    }
}
