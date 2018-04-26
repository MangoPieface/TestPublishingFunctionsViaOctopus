using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

public static class ReticulateSplines
{
    [FunctionName("ReticulateSplines")]
    public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            HttpRequestMessage req, TraceWriter log)
    {
       log.Info("Incoming Request request.");
        var myName = Environment.GetEnvironmentVariable("MyName", EnvironmentVariableTarget.Process);
        var release = Environment.GetEnvironmentVariable("Release", EnvironmentVariableTarget.Process);
        var reponse = new { Message = $"Hello {myName}", Release = release };
        return req.CreateResponse(HttpStatusCode.OK, reponse);
    }
}