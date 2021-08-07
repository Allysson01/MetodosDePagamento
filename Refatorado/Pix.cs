using MetodosDePagamento.Refatorado.Interface;

namespace MetodosDePagamento.Refatorado
{
    public class Pix : IValidaMetodos
    {
        public bool EhValido(Produto produto)
        {
            return produto.EhDinheiro;
        }

        public ValorCorrigido MudaValor(Produto produto)
        {
            int valorDesconto = 10;
            var resultado = (decimal)produto.Valor - (produto.Valor / 100 * valorDesconto);
            var valorCorrigido = new ValorCorrigido(resultado, true, valorDesconto);
            return valorCorrigido;
        }
    }
}
