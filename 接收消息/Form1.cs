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
using System.Threading;

namespace 接收消息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls=false;
        }
        string mq_path = Path.Combine(@".\private$", "yesok");
        private void 檢索消息_Click(object sender, EventArgs e)
        {
            MessageQueue mq=new MessageQueue(mq_path);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

            System.Messaging.Message ms = mq.Receive();

            // 顯示在標籤上
            label1.Text = $"{ms.Id}-{ms.Body.ToString()}";

            ms.Dispose();
            mq.Dispose();
            mq.Close();
        }
        MessageQueue Recieve_MQ = new MessageQueue();
        private void 不間斷檢索消息_Click(object sender, EventArgs e)
        {
            Recieve_MQ.Path = mq_path;
            Recieve_MQ.Formatter=new XmlMessageFormatter(new Type[] {typeof(string) });

            // 注意Recieve_MQ_ReceiveCompleted 這個事件只能由非同步動作 BeginReceive來引發
            Recieve_MQ.ReceiveCompleted += Recieve_MQ_ReceiveCompleted;
            Recieve_MQ.BeginReceive();
        }
        // 事件的第一個參數 sender是綁定事件的物件
        // 事件的第二個參數 e是觸發事件的物件
        private void Recieve_MQ_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            // 顯示在標籤上
            label1.Text = $"{e.Message.Id}-{e.Message.Body}";
            Recieve_MQ.BeginReceive();
        }

        private void 檢索事務消息_Click(object sender, EventArgs e)
        {
            MessageQueue mq=new MessageQueue(mq_path);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

            MessageQueueTransaction mt = new MessageQueueTransaction();
            mt.Begin();

            System.Messaging.Message ms = mq.Receive(mt);
            // 顯示在標籤上
            label1.Text = $"{ms.Id}-{ms.Body.ToString()}";
            mt.Commit();

            ms.Dispose();
            mt.Dispose();
            mq.Dispose();
            mq.Close();
        }

        MessageQueue Peek_MQ=new MessageQueue();
        private void 不間斷掃視事務消息_Click(object sender, EventArgs e)
        {
            Peek_MQ.Path = mq_path;
            Peek_MQ.PeekCompleted += Peek_MQ_PeekCompleted;
            Peek_MQ.BeginPeek();
        }

        private void Peek_MQ_PeekCompleted(object sender, PeekCompletedEventArgs e)
        {
            Handle_Message(e.Message.LookupId);
            Peek_MQ.BeginPeek();
        }

        // 處理事務消息
        private void Handle_Message(Int64 ms_lookupid) // long = Int64
        {
            MessageQueue Recieve_MQ=new MessageQueue(mq_path);
            Recieve_MQ.Formatter=new XmlMessageFormatter(new Type[] {typeof(string) });

            MessageQueueTransaction mt = new MessageQueueTransaction();
            mt.Begin();

            System.Messaging.Message ms = Recieve_MQ.ReceiveByLookupId(MessageLookupAction.Current, ms_lookupid, mt);
            // 顯示在標籤上
            label1.Text = $"{ms.Id}-{ms.Body.ToString()}";

            mt.Commit();
            ms.Dispose();
            mt.Dispose();
            Recieve_MQ.Dispose();
            Recieve_MQ.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mq_path = Path.Combine(@".\private$", "yesok");
            MessageQueue mq = new MessageQueue(mq_path);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            System.Messaging.Message ms = mq.PeekByLookupId(MessageLookupAction.Current, Convert.ToInt64("288230376151714612"));
            var x = ms.Body.ToString();
        }
    }
}
