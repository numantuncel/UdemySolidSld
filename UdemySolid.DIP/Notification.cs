using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.DIP
{
    // yüksek seviye class
    public class Notification
    {
        private ISenderInterface _sender;
        public Notification()
        {
            _sender = new Email();// mail üzerinde oluşan arayüz
        }
        public void SendNotification()
        {
            _sender.send();// arayüz mail üzerinde oluşturulur
            // bu yüzden de düşük seviyeli module bağımlılığı kalmaz.
        }
    }
}
