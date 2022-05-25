using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class MaquinaDeCocaCola
    {
        //Estados
        private int ESPERANDO_DINHEIRO = 0;
        private int COM_DINHEIRO = 1;
        private int PRODUTO_NO_DISPENSER = 2;
        private int VAZIA = 3;

        //sempre vai olhar o estado atual :)
        private int State;
        private int Qtd;

        public MaquinaDeCocaCola( int qtd)
        {
            this.State = ESPERANDO_DINHEIRO;
            this.Qtd = qtd; 
        }

        public void InserirDinheiro()
        {
            if(this.State == this.ESPERANDO_DINHEIRO)
            {
                this.State = this.COM_DINHEIRO;
                Console.WriteLine("Agora escolha o produto");
            }
            else if(this.State == COM_DINHEIRO)
            {
                Console.WriteLine("Você já colocou dinheiro, retire o dinheiro no dispenser de dinheiro :P");
            }
            else if(this.State == VAZIA)
            {
                Console.WriteLine("Não posso aceitar o dinheiro, não renho produto para vender :(");
            }
            else if(this.State == PRODUTO_NO_DISPENSER)
            {
                Console.WriteLine("Tire o produto no dispense primeiro :P"); 
            }
        }


        public void RemoverDinheiro()
        {
            if(this.State == COM_DINHEIRO)
            {
                this.State = ESPERANDO_DINHEIRO;
                Console.WriteLine("Você removeu o dinheiro :P"); 
            }
        }

        public void EscolherProduto()
        {
            if(this.State == COM_DINHEIRO)
            {
                this.State = this.PRODUTO_NO_DISPENSER;
                Console.WriteLine("Você escolheu um produto no dispenser"); 
            }
        }
    }
}
