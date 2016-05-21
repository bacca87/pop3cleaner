using OpenPop.Common.Logging;

namespace Pop3Eraser
{
    class POP3EraserLogger : ILog
    {
        IOutput output;
        
        public POP3EraserLogger(IOutput output)
        {
            this.output = output;
        }

        public void LogDebug(string message)
        {
            output.Debug(message);
        }

        public void LogError(string message)
        {
            output.Write(message);
        }
    }
}
