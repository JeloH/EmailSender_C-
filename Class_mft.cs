using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Net.Mail;
using System.ComponentModel;
using System.Windows.Forms;
using  System.Net;

namespace WindowsFormsApplication11_Part_SMS
    
{


    class Class_mft
    {




          
        // ترجیحا در این نرمافزار از Gmail استفاده می شود
        public void SendMessage(string from, string to, string subject, string MessageTxT, string user, string password, string strAtta)
        { 
           
             
                MailAddress From = new MailAddress("hjelovdar@gmail.com");

              //  MailAddress From = new MailAddress(from);

//                MailAddress To = new MailAddress("hjelovdar@gmail.com");
                MailAddress To = new MailAddress(to);

                MailMessage Message = new MailMessage(From, To);

             //   Message.Bcc = "hajelovdar@yahoo.com";
                Message.BodyEncoding = System.Text.Encoding.UTF8;  //or//
              
                Message.Body = MessageTxT;

                Message.Subject = subject;

                SmtpClient Client = new SmtpClient("smtp.gmail.com", 587);

                NetworkCredential Credential = new NetworkCredential("hjelovdar", "lkjak123212");

                Client .Credentials = Credential ;

               Client .EnableSsl = true;
             
               

             //  Message.Attachments.Add(new Attachment(@strAtta));

              
                Client .Send(Message);

                Client .SendCompleted += new SendCompletedEventHandler(Client_SendCompleted);

                Message.Dispose();
            


        }

          private void EmailWithProgress(string str)
        {
             

            }
        



        public void SendMessage2(string from, string to, string subject, string MessageTxT, string user, string password, string strAtta)
        {

            try
            {
                MailAddress From = new MailAddress("hajelovdar@yahoo.com");
                //    MailAddress From = new MailAddress(from);

                //                MailAddress To = new MailAddress("hjelovdar@gmail.com");
                MailAddress To = new MailAddress(to);

                MailMessage Message = new MailMessage(From, To);

                Message.Body = MessageTxT;

                Message.Subject = subject;

                SmtpClient Client = new SmtpClient("smtp.yahoo.com", 25);

                NetworkCredential Credential = new NetworkCredential("hjelovdar", "!1#3(9@2");

                Client.Credentials = Credential;

                Client.EnableSsl = true;




                Message.Attachments.Add(new Attachment(@strAtta));


                Client.Send(Message);

                Client.SendCompleted += new SendCompletedEventHandler(Client_SendCompleted);

                Message.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }



        }


           
        
           
  

                void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Sending Completed");
                
                
                }


    public   static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }
    
    
    }
}


