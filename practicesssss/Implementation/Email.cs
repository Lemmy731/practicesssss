using practicesssss.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesssss.Implementation
{
    public class Email : INotify
    {
        public void SendNotification(string email)
        {
            Console.WriteLine($"send email to : {email}");
        }

       

        
    }
}
