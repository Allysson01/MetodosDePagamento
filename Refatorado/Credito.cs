using MetodosDePagamento.Refatorado.Interface;

namespace MetodosDePagamento.Refatorado
{
    public class Credito : IValidaMetodos
    {
        public bool EhValido(Produto produto)
        {
            return produto.EhCredito;
        }

        public ValorCorrigido MudaValor(Produto produto)
        {
            int valorAcrescimo = 5;
            var resultado = (decimal)produto.Valor + (produto.Valor / 100 * valorAcrescimo);
            var valorCorrigido = new ValorCorrigido(resultado, false, valorAcrescimo);
            return valorCorrigido;
        }
    }
}
