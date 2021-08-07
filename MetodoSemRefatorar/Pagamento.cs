namespace MetodosDePagamento
{
    public class Pagamento
    {
        public Pagamento() { }

        public ProdutoValorFinal Pagar(Produto produto)
        {
            ProdutoValorFinal valorFinal = new ProdutoValorFinal(produto);
            
            decimal calculoDesconto;
            var descontoDinheiro = 15;
            var descontoTranferencia = 10;
            var adicionalCredito = 5;
            var adicionalCheque = 25;


            if (produto.MetodosDePagento == MetodosDePagento.Dinheiro)
            {                
                calculoDesconto = (decimal)produto.Valor - (produto.Valor / 100 * descontoDinheiro);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddDesconto(descontoDinheiro);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Pix)
            {
                calculoDesconto = (decimal)produto.Valor - (produto.Valor / 100 * descontoTranferencia);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddDesconto(descontoTranferencia);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Transferencia)
            {
                calculoDesconto = (decimal)produto.Valor - (produto.Valor / 100 * descontoTranferencia);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddDesconto(descontoTranferencia);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Debito)
            {
                calculoDesconto = (decimal)produto.Valor - (produto.Valor / 100 * descontoTranferencia);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddDesconto(descontoTranferencia);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Boleto)
            {
                calculoDesconto = (decimal)produto.Valor - (produto.Valor / 100 * descontoTranferencia);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddDesconto(descontoTranferencia);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Credito)
            {
                calculoDesconto = (decimal)produto.Valor + (produto.Valor / 100 * adicionalCredito);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddAdicional(adicionalCredito);
            }

            if (produto.MetodosDePagento == MetodosDePagento.Cheque)
            {
                calculoDesconto = (decimal)produto.Valor + (produto.Valor / 100 * adicionalCheque);
                valorFinal.AddValor(calculoDesconto);
                valorFinal.AddAdicional(adicionalCheque);
            }

            return valorFinal;
        }
    }
}
