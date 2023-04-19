using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using Newtonsoft.Json;

namespace 傳送消息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mq_path = Path.Combine(@".\private$", "yesok");
        private void 產生隊列_Click(object sender, EventArgs e)
        {
            if (MessageQueue.Exists(mq_path))
                MessageQueue.Delete(mq_path);
            MessageQueue.Create(mq_path);
        }

        private void 產生交易性隊列_Click(object sender, EventArgs e)
        {
            if (MessageQueue.Exists(mq_path))
                MessageQueue.Delete(mq_path);
            MessageQueue.Create(path: mq_path, transactional: true);
        }

        private void 傳送消息_Click(object sender, EventArgs e)
        {
            MessageQueue mq = new MessageQueue(mq_path);
            System.Messaging.Message ms = new System.Messaging.Message();
            ms.Body = "abcd";
            ms.Label = "1001";
            mq.Send(ms);
            // 顯示在標籤
            label1.Text = $"{ms.Id}-{ms.Body.ToString()}";
            ms.Dispose();
            mq.Dispose();
            mq.Close();
        }

        private void 傳送交易性消息_Click(object sender, EventArgs e)
        {
            MessageQueue mq = new MessageQueue(mq_path);
            MessageQueueTransaction mt = new MessageQueueTransaction();

            // 信息內容
            Order_Detail order_Detail = new Order_Detail
            {
                OrderId = 1,
                CustomerName = "yu",
                ProductName = "Apple",
                Count = 10,
                Price = 2000
            };
            string message_json = JsonConvert.SerializeObject(order_Detail);

            System.Messaging.Message ms = new System.Messaging.Message(message_json);
            ms.Label = "1001";

            mt.Begin();
            mq.Send(message_json, mt);
            mt.Commit();

            // 標籤顯示
            label1.Text = $"{ms.Id}-{ms.Body.ToString()}";

            ms.Dispose();
            mq.Dispose();  
            mq.Close();
            mt.Dispose();

        }

       
    }
    public class Order_Detail
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
