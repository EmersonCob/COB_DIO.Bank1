using System;

namespace COB_DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "José Emerson");
            
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
