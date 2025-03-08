using ScaffNet.Utils.EventHandling;

namespace ScaffNetAPI.Utils
{
    internal class ScaffEventHandler : IScaffEventHandler
    {
        private ILogger<ScaffEventHandler> _logger { get; set; }
        public ScaffEventHandler(ILogger<ScaffEventHandler> logger)
        {
            _logger = logger;
        }

        public void OnDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void OnInfo(string message)
        {
            _logger.LogInformation(message);
        }

        public void OnWarning(string message)
        {
            _logger.LogWarning(message);
        }

        public void OnError(string message)
        {
            _logger.LogError(message);
        }

        public void OnCritical(string message)
        {
            _logger.LogCritical(message);
        }
    }
}
