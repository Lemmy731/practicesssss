using practicesssss.Implementation;
using practicesssss.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace practicesssss
{
    public class DisplayArea
    {
        private readonly INotify _notify;

        public DisplayArea(INotify notify)
        {
            this._notify = notify;
        }

        public void AddUser()
        {
           
            string sms = "0909499494";
            _notify.SendNotification(sms);
           
        }

        
        
    }
}
