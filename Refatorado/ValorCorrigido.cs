namespace MetodosDePagamento.Refatorado
{
    public class ValorCorrigido
    {
        public ValorCorrigido(decimal valor, bool ehDesconto, int valorDesconto)
        {
            Valor = valor;
            EhDesconto = ehDesconto;
            ValorDesconto = valorDesconto;
        }

        public decimal Valor { get; }
        public int ValorDesconto { get; }
        public bool EhDesconto { get; }
    }
}
