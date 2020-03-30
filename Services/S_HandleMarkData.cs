using FirstServer.Data;
using FirstServer.Handles;
using FirstServer.Message;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace FirstServer.Services
{
    public class S_HandleMarkData:HandleMarkDataService.HandleMarkDataServiceBase
    {


        public ILogger<S_HandleMarkData> Logger { get; }
        public FirstServerDbcontext FirstServerDbcontext { get; }

        public S_HandleMarkData(ILogger<S_HandleMarkData> logger,Data.FirstServerDbcontext firstServerDbcontext) {
            Logger = logger;
            FirstServerDbcontext = firstServerDbcontext;
        }

        public override Task<HandleMarkDataRequest> HandleMD(HandleMarkData request, ServerCallContext context)
        {


            ///   HMarkData.HandlerData();


            var resp = new HandleMarkDataRequest
            {
                Status = 200,
                Msh = "12312",
                Data = "111223",
                R1 = "21312",
                R2 = "111"

            };

            return Task.FromResult(resp);
        }
    }
}
