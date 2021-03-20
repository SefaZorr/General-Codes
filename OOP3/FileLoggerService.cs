using System;

namespace OOP3
{
    //interfaceden ayırıp yazarsak o referans avantajından yararlanamayız.
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
