
namespace Logging
{
    public class Starter
    {
        public static void Run()
        {
            string[] _logArray = new string[100]; 
            Random rnd = new();
            Result res;
            for (int i = 0; i < 100; i++)
            {
                switch (rnd.Next(1,4))
                {
                    case 1:
                        res = Actions.InfoMethod();
                        break;
                    case 2:
                        res = Actions.WarningMethod();
                        break;
                    case 3:
                        res = Actions.ErrorMethod();
                        break;
                    default:
                        res = new() { ErrorMessage = "Something went wrong..." , Status = false};
                        break;
                }
                if (res.Status == false)
                {
                    Logger.Message(Logger.LogType.Error, $"Action failed by a reason: {res.ErrorMessage}");
                }

                //Comment to remove the pause(used for showing the difference)
                System.Threading.Thread.Sleep(20);
            }
            File.WriteAllText("log.txt", Logger.LogData);
        }
    }
}
