using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace keda
{
    [ServiceBusAccount("sbconn")]
    public static class SBQueueToSql
    {
        [FunctionName("SBQueueToSql")]
        public static void Run([ServiceBusTrigger("incoming")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
