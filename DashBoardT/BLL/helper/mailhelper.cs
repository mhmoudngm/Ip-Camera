using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DashBoardT.BLL.helper
{
    public class mailhelper
    {
        public static String sendmail(String title,String message)
        {

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.EnableSsl = true;
               
                smtp.Credentials = new NetworkCredential("mahmoudhamdi1096@gmail.com", "151096ngm");


                smtp.Send("mahmoudhamdi1096@gmail.com", "mahmoudhamdi1096@gmail.com", title, message);

                return "Mail Sent Successfully";

            }
            catch (Exception ex)
            {
                return "Mail not Send";
            }

        }

    }
}
