using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.IO;
using System.Threading;

namespace 觸發器用的主控台程式
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("123456");
            Console.ReadLine();

            if (args.Length > 0)
            {
                // 延遲十秒
                Thread.Sleep(1000);

                // 產生資料夾
                string folder_path = Path.Combine(Directory.GetCurrentDirectory(), "Myfiles");
                if(!Directory.Exists(folder_path))
                    Directory.CreateDirectory(folder_path);
                // 產生檔案路徑
                string file_path = Path.Combine(folder_path, $"{ Guid.NewGuid()}.txt");
                
                Int64 lookupId= Convert.ToInt64(args[0]);
                string mq_path = Path.Combine(@".\private$", "yesok");
                MessageQueue mq = new MessageQueue(mq_path);
                mq.Formatter = new XmlMessageFormatter(new Type[] {typeof(string) });

                System.Messaging.Message ms = mq.PeekByLookupId(MessageLookupAction.Current, lookupId);

                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"MessageId : {ms.Id}");
                builder.AppendLine($"MessageLookupId : {args[0]}");
                builder.AppendLine($"Message.Body : {ms.Body.ToString()}");

                ms.Dispose();
                mq.Dispose();
                mq.Close();

                File.WriteAllText(file_path, builder.ToString());

            }
        }
    }
}
