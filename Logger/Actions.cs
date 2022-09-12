namespace Logging
{
    public class Actions
    {
        public static Result InfoMethod()
        {
            string msg = "Start method: InfoMethod";
            Result r1 = new() { ErrorMessage = msg , Status = true};
            Logger.Message(Logger.LogType.Info, msg);
            return r1;
        }
        public static Result WarningMethod()
        {
            string msg = "Skipped Logic in method: WarningMethod";
            Result r2 = new() { ErrorMessage = msg, Status = true };
            Logger.Message(Logger.LogType.Warning, msg);
            return r2;
        }
        public static Result ErrorMethod()
        {
            string msg = "I broke a logic";
            Result r3 = new() { ErrorMessage = msg, Status = false };
            Logger.Message(Logger.LogType.Error, msg);
            return r3;
        }
    }
}
