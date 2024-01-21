using Infrastructure.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrossCuttingConcern.MailOp
{
    public class MailManager
    {
        public static bool Send(string to,string title,string message)
        {
            MailMessage mail = new MailMessage(CoreKeys.EMAILADDRESS,to);
            mail.Subject = title;
            mail.Body = message;
            mail.IsBodyHtml = true; // body de html kullanılacak mı kullanılmayacak mı true yazarsak html kodları kullanılabilir.

            //mail.Attachments //maile kod ile dosya ekleyebiliyorsunuz.
            //mail.Attachments.Add(new Attachment("C:file.zip"));

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(CoreKeys.EMAILUSER, CoreKeys.EMAILPASSWORD);
            //smtp.Host = "smtp-mail.outlook.com"; // senin özel bir mail adresin yani domainin varsa veya google hotmail gibi servislerinin özel host bağlantı linki olur onu koyman lazım.
            //örnek olarak www.aysun.net     smtp-aysunyazilim.aysun.com     smtp.gmail.com (eski gmail hesaplarında kullanılır.)
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587; //Port 25, 465, or 587 bu port adresleri eskiden kullanılıyordu. 25 i kim kaybetti => Türkler tarafından çok mail atıldığı için 25 portu kaldırıldı. 465 ve 587 portu gmail tarafında destek vermektedir.

            smtp.EnableSsl= true; //Bu değer şirket mailleri için false olarak yazılmalı . (domainli mailler için) 
            smtp.Send(mail);

            return true;
        }

    }
}
