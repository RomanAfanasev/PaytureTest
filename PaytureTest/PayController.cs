using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PaytureTest
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public PayController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<PayResponse> Get()
        {
            var payInfoBuilder = new PayInfoBuilder();
            
            var payInfo = payInfoBuilder.SetPAN("654111111111100000")
                .SetEMonth(12)
                .SetEYear(22)
                .SetCardHolder("Ivan Ivanov")
                .SetSecureCode(123)
                .SetOrderId(Guid.NewGuid().ToString())
                .SetAmount(12430)
                .Build(); 


            var payRequestBuilder = new PayRequestBuilder();
            
            var requestUri = payRequestBuilder.SetKey("Merchant")
                .SetAmount("12706")
                .SetOrderId(Guid.NewGuid().ToString())
                .SetPayInfo(payInfo)
                .Build();


            var client = _clientFactory.CreateClient();

            var response = await client.PostAsync(requestUri, null);
            string xml = await response.Content.ReadAsStringAsync();

            var res = new PayResponse();
            res = (PayResponse) XmlHelper.XmlDeserializeFromString(xml, typeof(PayResponse));

            return res;
        }
    }
}