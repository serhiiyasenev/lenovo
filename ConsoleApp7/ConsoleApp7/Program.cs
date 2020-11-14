using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsgReader;
using Rebex.Mail;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Serhii\Downloads\message.eml";
            string path2 = @"C:\Users\Serhii\Downloads\message2.eml";
            string path3 = @"C:\Users\Serhii\Downloads\message3.eml";


            FileStream messageFile = File.Open(path, FileMode.Open, FileAccess.Read);

            StreamReader red = new StreamReader(messageFile);
            var gg = red.ReadToEnd();
            Console.WriteLine(red.ReadToEnd());
            

            var st = new FileStream(path2, FileMode.Open, FileAccess.Read);
            try
            {
                var rrwrwrw = MsgReader.Mime.Message.Load(st);
                var ee = rrwrwrw.HtmlBody.GetBodyAsText();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                FileInfo ffInfo = new FileInfo(path3);

                var rrwrwr1w = MsgReader.Mime.Message.Load(st);
            }
            




            string text = null;

            var fffile = new MsgReader.Outlook.Storage.Message(messageFile);

            var msgReader = new Reader();
            var sss = msgReader.ExtractMsgEmailBody(messageFile, true, "multipart/alternative");
            var aa = msgReader.ExtractMsgEmailBody(new MsgReader.Outlook.Storage.Message(messageFile), false, "text/html; base64");

            using (var fs = File.Open(path3, FileMode.Open, FileAccess.Read, FileShare.Read))
            { using (var msg = new MsgReader.Outlook.Storage.Message(fs))
                { var msg1Reader = new Reader();
                    text = msgReader.ExtractMsgEmailBody(msg, true, "text/html; charset=utf-8");
                }
            }

            Console.WriteLine("----------------------");

            Console.WriteLine(red.ReadToEnd());
            
            messageFile.Close();
            red.Close();
        }
    }
}
