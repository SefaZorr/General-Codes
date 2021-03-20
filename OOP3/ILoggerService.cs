using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Loglama kim ne zaman hangi operasyonu çagırdıdır yani bir nevi o sistemde olan hareketleri döktügümüz dökümdür.Loglama dedigimiz zaman loglamayı farklı yontemlerle
    //uygulabilirz mesela logları bir doyada yada veritabanında yada sms olarak tutabiliriz.Mesela birisi bir krediye başvuru yaptıgı zaman bir sms gitmesi bir loglama
    //türüdür,mail gitmesi vs loglamanın alternatifidir.
    interface ILoggerService
    {
        void Log();
    }
}
