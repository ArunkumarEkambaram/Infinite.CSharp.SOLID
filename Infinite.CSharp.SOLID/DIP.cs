using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.SOLID
{
    public interface IMessage
    {
        void SendMessage();
    }

    public class Email : IMessage //Low Level Module
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Send Greeting thru Email");
        }
    }

    public class WhatsApp : IMessage//Low Level Module
    {
        public string MobileNo { get; set; }
        public string Subject { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Send Message thru WhatsApp");
        }
    }

    public class OnlineGreetingCard : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Send Message thru Greetings Card");
        }
    }

    //public class Greetings//High Level Module
    //{
    //    public List<IMessage> _message;

    //    public Greetings(List<IMessage> messages)
    //    {
    //        _message = messages;
    //    }

    //    public void SendMessage()
    //    {
    //        foreach (var message in _message)
    //        {
    //            message.SendMessage();
    //        }
    //    }

    //}

    public class Greetings //High-Level Module
    {
        private IMessage _message;

        public Greetings(IMessage message)
        {
            _message = message;
        }

        public void SendMessage()
        {
            _message.SendMessage();
        }
    }

    public class TestClass
    {
        static void Main(string[] args)
        {
            //List<IMessage> messages = new List<IMessage>
            //{
            //    new Email(),
            //    new WhatsApp()
            //};
            //Greetings greetings = new Greetings(messages);
            //greetings.SendMessage();

            Greetings greetings = new Greetings(new OnlineGreetingCard());
            greetings.SendMessage();
        }
    }
}

/*
 public void SendGreetings(string subject)
        {
            //Email
            _email = new Email();
            _email.SendMail("To", "From", subject);
            Console.WriteLine("Greeting sent thru Email");

            //WhatsApp
            _whatsApp = new WhatsApp();
            _whatsApp.SendMessage();
        }
 */

//IMessge msg = new Email();