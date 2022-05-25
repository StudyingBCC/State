using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDOS A MINHA MAQUINA DE COCA-COLA");

            MaquinaDeCocaCola cliente = new MaquinaDeCocaCola(20);

            cliente.InserirDinheiro();
            cliente.EscolherProduto();
            cliente.RemoverDinheiro();
        }
    }
}
