using System.Threading.Tasks;
using PratikCode.Payment.Core.Domain.Dtos;
using PratikCode.Payment.Core.Domain.Providers;

namespace PratikCode.Payment.Infrastructure.Providers
{
    public class XProvider : ICreditCardPaymentProvider
    {
        private const string ProviderCode = "XProviderCode";
        public bool AppliesTo(string providerCode)
        {
            return providerCode.Equals(ProviderCode);
        }

        public Task<CcPaymentResultDto> Pay(CcPaymentRequestDto dto)
        {
            return Task.FromResult(new CcPaymentResultDto
            {
                ProvisionCode = ProviderCode
            });
        }
    }
}