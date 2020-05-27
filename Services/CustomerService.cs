using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Grpc.Core;

using AutoMapper;

namespace PetHealth.API.GRPC
{    
    public class CustomerService : Customer.CustomerBase
    {


        public CustomerService()
        {
        }

        public override Task<IsProductAddressUpdateAllowedResponse> IsProductAddressUpdateAllowed(IsProductAddressUpdateAllowedRequest request, ServerCallContext context)
        {
            try
            {
                IsProductAddressUpdateAllowedResponse result = new IsProductAddressUpdateAllowedResponse();

                // hard code to true for now
                result.AddressUpdatable = true;
                result.ReturnMessage = $"Hello Howell! You are changing from { request.StateFrom } to { request.StateTo } for User { request.Userrelationid }";

                //return responsse object
                return Task.FromResult(result);

            }
            catch(Exception ex)
            {
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }

        }

    }
}