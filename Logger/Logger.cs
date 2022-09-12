using System.Runtime.CompilerServices;

namespace Logging
{
    public class Logger
    {
        private static readonly Logger Instance = new();
        public static string? LogData;
        public enum LogType
        {
            Error,
            Warning,
            Info,
        }
        static Logger()
        {
        }
        private Logger()
        {
        }
        public static Logger GetInstance
        {
            get
            {
                return Instance;
            }
        }

        public static void Message(LogType type, string details)
        {
            string ConstructMessage = $"{DateTime.Now:T}: {type}: {details}";
            LogData += $"{ConstructMessage}\n";
        }

    }
}