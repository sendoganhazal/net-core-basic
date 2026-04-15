namespace Interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Veritabanina log yazar");
        }
    }

}
