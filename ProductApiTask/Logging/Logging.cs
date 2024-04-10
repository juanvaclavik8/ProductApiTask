using System.Text;

namespace ProductApiTask.Logging
{
    // Logging to file
    public class Logging : ILogging
    {
        public void Log(string message, string status)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(status);
            sb.Append(" -- ");
            sb.Append(message);
            sb.Append(" -- ");
            sb.Append(DateTime.Now.ToString());

            File.AppendAllText("ProductApiLog.txt",  sb.ToString() + Environment.NewLine);
            sb.Clear();
        }
    }
}
