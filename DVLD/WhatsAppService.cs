using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

public class WhatsAppService
{
    public static void Send(string toNumber, string message)
    {
        string sid = ConfigurationManager.AppSettings["TwilioSid"];
        string token = ConfigurationManager.AppSettings["TwilioToken"];
        string from = ConfigurationManager.AppSettings["TwilioWhatsAppFrom"];

        // init Twilio (سطر لوحده)
        TwilioClient.Init(sid, token);

        MessageResource.Create(
            from: new PhoneNumber(from),
            to: new PhoneNumber("whatsapp:" + toNumber),
            body: message
        );
    }
}
