using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Channel;
using FamilyHubs.ServiceDirectory.Shared.Helpers;

namespace FamilyHubs.ServiceDirectory.Shared.Logging;

public class ServiceNameTelemetryInitializer : ITelemetryInitializer
{
    private string _serviceName;

    public ServiceNameTelemetryInitializer(string serviceName)
    {
        Guard.IsNullOrWhiteSpace(serviceName, nameof(serviceName));
        _serviceName = serviceName;
    }

    public void Initialize(ITelemetry telemetry)
    {
        if (!telemetry.Context.GlobalProperties.ContainsKey(LoggingConstants.ServiceNamePropertiesName))
        {
            telemetry.Context.GlobalProperties.Add(LoggingConstants.ServiceNamePropertiesName, _serviceName);
        }
    }
}
