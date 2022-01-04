namespace Acme.Common
{
    using System;
    using Acme.Common.Contracts;
    using System.Collections.Generic;
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
