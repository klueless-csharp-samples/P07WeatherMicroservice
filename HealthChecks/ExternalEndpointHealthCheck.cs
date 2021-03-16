using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using P07WeatherMicroservice.Models;

namespace P07WeatherMicroservice.Services
{
  public class ExternalEndpointHealthCheck : IHealthCheck
  {
    private ServiceSettings settings;

    public ExternalEndpointHealthCheck(IOptions<ServiceSettings> options)
    {
      settings = options.Value;
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
      Ping ping = new();

      var reply = await ping.SendPingAsync(settings.OpenWeatherHost);

      if (reply.Status != IPStatus.Success)
      {
        return HealthCheckResult.Unhealthy();
      }

      return HealthCheckResult.Healthy();
    }
  }
}
