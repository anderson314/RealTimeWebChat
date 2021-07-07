using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace SignalRChatServer
{
    public class Chat : Hub
    {
        public static List<Message> Messages;

        public Chat()
        {
            if (Messages == null)
                Messages = new List<Message>();
        }

        public void NewMessage(string userName, string text)
        {
            Clients.All.SendAsync("newMessage", userName, text);
            Messages.Add(new Message()
            {
                Text = text,
                UserName = userName

            });
        }

        public void NewUser(string userName, string connectionId)
        {
            Clients.Client(connectionId).SendAsync("previosMessages", Messages);
            Clients.All.SendAsync("newUser", userName);
        }
    }

    public class Message
    {
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}
