using System.Threading.Tasks;
using PratikCode.Payment.Core.Domain.Dtos;

namespace PratikCode.Payment.Core.Domain.Providers
{
    public interface ICreditCardPaymentProvider
    {
        bool AppliesTo(string providerCode);
        Task<CcPaymentResultDto> Pay(CcPaymentRequestDto dto);
    }
}