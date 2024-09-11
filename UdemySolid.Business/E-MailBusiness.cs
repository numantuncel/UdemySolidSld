using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Business
{
    public class E_MailBusiness
    {
        public bool EmailValidator(string Email)
        {
            // Düzenle
            return true;
        }
        public void SendEmail(string Email)
        {
            EmailValidator(Email);

            // E mail gönder
        }

    }
}
// Tek sorumlukuk yine e mailin ayrı alındığı düzenlendiği, ayrı gönderildiği iki metod 