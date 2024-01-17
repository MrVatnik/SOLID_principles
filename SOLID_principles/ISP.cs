using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //this class implements ISP. ISP is:
    //"Clients should not be forced to depend upon interfaces that they do not use."
    //This principle allows you to avoid overcomplicating interfaces by bloating them and creating
    //often unnecessary fields.

    //For example: here i splited IMessage interface, to stop implementing there fields, which is not requaried in 
    //every next class. For example: most of messages require text, but not voice messages. So messages overall should
    //not implement text field, becouse it would stay unused in voice messages. The same is with Voice byte array.

    interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }

    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }

    class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; } = "";
        public string FromAddress { get; set; } = "";

        public byte[] Voice { get; set; } = Array.Empty<byte>();
        public void Send() => Console.WriteLine("sending voice mail");
    }
    class EmailMessage : IEmailMessage
    {
        public string Text { get; set; } = "";
        public string Subject { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";

        public void Send() => Console.WriteLine("Sending message via Email: {Text}");
    }

    class SmsMessage : ITextMessage
    {
        public string Text { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";
        public void Send() => Console.WriteLine("Sending message via Sms: {Text}");
    }
}
