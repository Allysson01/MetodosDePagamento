namespace MetodosDePagamento.Refatorado.Interface
{
    public interface IValidaMetodos
    {
        bool EhValido(Produto produto);

        ValorCorrigido MudaValor(Produto produto);
    }
}
