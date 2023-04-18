using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5.Model
{
    public class Message
    {
        public string messageContent { get; set; }

        public DateTime messageTime { get; set; }

        public string messageSender { get; set; }

        public Message(string messageContent, string messageSender)
        {
            this.messageContent = messageContent;
            this.messageTime = DateTime.Now;
            this.messageSender = messageSender;
        }


    }
}
