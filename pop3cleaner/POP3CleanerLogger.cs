using OpenPop.Common.Logging;

namespace Pop3Cleaner
{
    class POP3CleanerLogger : ILog
    {
        IOutput output;
        
        public POP3CleanerLogger(IOutput output)
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
