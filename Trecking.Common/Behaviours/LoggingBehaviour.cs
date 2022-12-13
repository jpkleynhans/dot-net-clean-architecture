namespace Trecking.Common.Behaviours;

public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>
{
    public async Task Process(TRequest request, CancellationToken cancellationToken)
        => Logging.Logging.LogInfo($"Trecking Request: {typeof(TRequest).Name}", request);
}
