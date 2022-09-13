using System.Runtime.CompilerServices;
using System.Text;

namespace Logging
{
    public class Logger
    {
        private static readonly Logger Instance = new();
        public StringBuilder LogData = new();
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

        public void Message(LogType type, string details)
        {
            string ConstructMessage = $"{DateTime.Now:T}: {type}: {details}";
            LogData.AppendLine($"{ConstructMessage}");
        }

    }
}