using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Configuration;

namespace PetHealth.API.GRPC
{
    public class ShoppingCartService : ShoppingCart.ShoppingCartBase
    {
        
        private readonly IConfiguration _configuration;

        public ShoppingCartService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override Task<InsuranceTrialLinkGetResponse> InsuranceTrialLinkGet(InsuranceTrialLinkGetRequest request, ServerCallContext context)
        {
            try
            {
                ShoppingCartRepository repository = new ShoppingCartRepository(_configuration);
                var result = repository.GetInsuranceTrialLink(request);
                return Task.FromResult(result);
                //    return new InsuranceTrialLinkGetResponse { IsValid = false, ErrorMessage="Used Code", TrialURL="http://www.google.ca"};
            }
            catch(Exception ex)
            {
                throw new RpcException(new Status(StatusCode.Internal, "ShoppingCartService " + ex.Message));
            }
        }
    }
}
