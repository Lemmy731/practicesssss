using practicesssss.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesssss.Implementation
{
    public class SMS : INotify
    {
        public void SendNotification(string sms)
        {
            Console.WriteLine($"send sms to {sms}");    
        }
    }
}
