namespace SFinder.Domain.Core.Shared
{
    public enum eFormaPagamento : int
    {
        DinheiroAVista = 1,
        CartaoDebito = 2,
        CartaoCreditoAVista = 3,
        CartaoCreditoParcelado = 4,
        PayPal = 5,
    }

    public enum eFormaCobranca : int
    {
        PorHora = 1,
        PorServico = 2,
    }
}
