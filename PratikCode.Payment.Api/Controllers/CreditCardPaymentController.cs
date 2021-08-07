using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PratikCode.Payment.Core.Domain.Dtos;
using PratikCode.Payment.Core.Domain.Providers;

namespace PratikCode.Payment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditCardPaymentController : ControllerBase
    {
        private IEnumerable<ICreditCardPaymentProvider> _paymentProviders;

        public CreditCardPaymentController(IEnumerable<ICreditCardPaymentProvider> paymentProviders)
        {
            _paymentProviders = paymentProviders;
        }

        //temporary
        [HttpPost]
        public async Task<IActionResult> Pay(CcPaymentRequestDto request)
        {
            var provider = _paymentProviders.FirstOrDefault(x => x.AppliesTo(request.ProviderCode));
            return Ok(await provider.Pay(request));
        }
    }
}