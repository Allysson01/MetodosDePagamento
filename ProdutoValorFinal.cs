using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDePagamento
{
    public class ProdutoValorFinal
    {
        public ProdutoValorFinal(Produto produto)
        {
            Produto = produto;
            ValorFinal = 0;
        }

        public string Msg { get; private set; }

        public Produto Produto { get; }

        public int Adicional { get; private set; }

        public int Desconto { get; private set; }

        public decimal ValorFinal { get; private set; }

        internal void AddValor(decimal valor)
        {
            ValorFinal = valor;
        }

        internal void AddAdicional(int adicional)
        {
            Adicional = adicional;
        }

        internal void AddDesconto(int desconto)
        {
            Desconto = desconto;
        }

        internal void AddMsg(string mensagem)
        {
            Msg = mensagem;
        }
    }
}
