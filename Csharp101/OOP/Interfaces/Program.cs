namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileLogger fileLogger = new FileLogger();
            // fileLogger.WriteLog();

            // DatabaseLogger dbLogger = new DatabaseLogger();
            // dbLogger.WriteLog();

            // SmsLogger smsLogger = new SmsLogger();
            // smsLogger.WriteLog();

            LogManager fileLogger = new LogManager(new FileLogger());
            fileLogger.WriteLog();

            LogManager dbLogger = new LogManager(new DatabaseLogger());
            dbLogger.WriteLog();

            LogManager smsLogger = new LogManager(new SmsLogger());
            smsLogger.WriteLog();
        }
    }

}

