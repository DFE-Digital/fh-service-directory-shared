using FamilyHubs.ServiceDirectory.Shared.Helpers;
using Microsoft.ApplicationInsights;

namespace FamilyHubs.ServiceDirectory.Shared.Logging;

public interface IAppTelemetry
{
    /// <summary>
    /// Send an <see cref="EventTelemetry"/> for display in Diagnostic Search and aggregation in Metrics Explorer.
    /// </summary>
    /// <remarks>
    /// <a href="https://go.microsoft.com/fwlink/?linkid=525722#trackevent">Learn more</a>
    /// </remarks>
    /// <param name="eventName">A name for the event.</param>
    /// <param name="properties">Named string values you can use to search and classify events.</param>
    /// <param name="metrics">Measurements associated with this event.</param>
    void TrackEvent(string eventName, IDictionary<string, string>? properties = null, IDictionary<string, double>? metrics = null);
}

public class ApplicationInsightsTelemetrySink : IAppTelemetry
{
    private readonly TelemetryClient _client;

    public ApplicationInsightsTelemetrySink(TelemetryClient client)
    {
        Guard.ArgumentNotNull(client, nameof(client));
        _client = client;
    }

    public void TrackEvent(string eventName, IDictionary<string, string>? properties = null, IDictionary<string, double>? metrics = null)
    {
        _client.TrackEvent(eventName, properties, metrics);
    }
}
