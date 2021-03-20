using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        Campaing _campaing;
        public OrderManager(Campaing campaing)
        {
            _campaing = campaing; 
        }
        
        public void Sell()
        {
            Console.WriteLine(_campaing.Name + "Kampanyası Uygulandı");
        }

        public void Sell(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
