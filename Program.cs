using MetodosDePagamento.Refatorado;
using MetodosDePagamento.Refatorado.Interface;
using System;
using System.Collections.Generic;

namespace MetodosDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto("PS5", MetodosDePagento.Cheque);
            produto.Precifica(5000M);

            //Pagamento pagamento = new Pagamento();

            //var pag = pagamento.Pagar(produto);

            //var adiconalOuDesconto = "";
            //if (pag.Adicional > 0)
            //    adiconalOuDesconto = $"Adicional de : {pag.Adicional}%";

            //if (pag.Desconto > 0)
            //    adiconalOuDesconto = $"Desconto de : {pag.Desconto}%";

            //Console.WriteLine($"Produto: {pag.Produto.Nome} | Valor original: {pag.Produto.Valor} | Método de pagamento: {pag.Produto.MetodosDePagento} ");
            //Console.WriteLine($"{adiconalOuDesconto}");
            //Console.WriteLine($"Valor final do produto: {pag.ValorFinal:C}");
            //Console.ReadLine();

            var _ValidaMetodos = new List<IValidaMetodos> {
                  new Credito(),
                  new Debito(),
                  new Dinheiro(),
                  new Boleto(),
                  new Cheque(),
                  new Pix(),
                  new Transferencia(),
            };

            var validadorEstrategia = new ValidadorEstrategia(_ValidaMetodos);

            var resultado = validadorEstrategia.RetornaValorFinal(produto);

            Console.WriteLine($"Produto: {resultado.Produto.Nome} | Valor original: {resultado.Produto.Valor} | Método de pagamento: {resultado.Produto.MetodosDePagento} ");
            Console.WriteLine($"{resultado.Msg}");
            Console.WriteLine($"Valor final do produto: {resultado.ValorFinal:C}");
            Console.ReadLine();
        }
    }
}
