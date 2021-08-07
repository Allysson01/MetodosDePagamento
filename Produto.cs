namespace MetodosDePagamento
{
    public class Produto
    {
        public Produto(string nome, MetodosDePagento metodosDePagamento)
        {
            Nome = nome;
            MetodosDePagento = metodosDePagamento;
        }

        public string Nome { get; }
        public decimal Valor { get; private set; }
        public MetodosDePagento MetodosDePagento { get; }
        public bool EhCredito { get => MetodosDePagento == MetodosDePagento.Credito; }
        public bool EhDebito { get => MetodosDePagento == MetodosDePagento.Debito; }
        public bool EhDinheiro { get => MetodosDePagento == MetodosDePagento.Dinheiro; }
        public bool EhTransferencia { get => MetodosDePagento == MetodosDePagento.Transferencia; }
        public bool EhBoleto { get => MetodosDePagento == MetodosDePagento.Boleto; }
        public bool EhPix { get => MetodosDePagento == MetodosDePagento.Pix; }
        public bool EhCheque { get => MetodosDePagento == MetodosDePagento.Cheque; }
        internal void Precifica(decimal valor)
        {
            Valor = valor;
        }
    }
}
