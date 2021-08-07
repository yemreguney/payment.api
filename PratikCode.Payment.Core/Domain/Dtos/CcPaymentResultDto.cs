namespace PratikCode.Payment.Core.Domain.Dtos
{
    public class CcPaymentResultDto
    {
        public string TransactionId { get; set; }
        public string ProvisionCode { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}