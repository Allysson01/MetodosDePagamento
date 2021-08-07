using MetodosDePagamento.Refatorado.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MetodosDePagamento.Refatorado
{
    public class ValidadorEstrategia
    {
        readonly List<IValidaMetodos> _validaMetodos;
        public ValidadorEstrategia(List<IValidaMetodos> validaMetodos)
        {
            _validaMetodos = validaMetodos;
        }

        public ProdutoValorFinal RetornaValorFinal(Produto produto)
        {
            ProdutoValorFinal produtoValorFinal = new ProdutoValorFinal(produto);

            var meioPagamento = _validaMetodos.Where(x => x.EhValido(produto)).ToList();

            foreach (var item in meioPagamento)
            {
                var prod = item.MudaValor(produto);

                var adiconalOuDesconto = prod.EhDesconto ? $"Desconto de : {prod.ValorDesconto}%" 
                                         : $"Adicional de : {prod.ValorDesconto}%";

                produtoValorFinal.AddValor(prod.Valor);
                produtoValorFinal.AddMsg(adiconalOuDesconto);
            }

            return produtoValorFinal;
        }
    }
}
