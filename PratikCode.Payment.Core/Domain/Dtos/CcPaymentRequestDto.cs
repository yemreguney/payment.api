namespace PratikCode.Payment.Core.Domain.Dtos
{
    public class CcPaymentRequestDto
    {
        //temporary
        public string ProviderCode { get; set; }
        
        public string CreditCardHolderName { get; set; }
        public string CreditCardNumber { get; set; }
        public int CreditCardExpireMonth { get; set; }
        public int CreditCardExpireYear { get; set; }
    }
}