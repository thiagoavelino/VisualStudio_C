using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace VisualStudio_C.Twilio {
    class SMSTextMsg {
        static void Main() {
            // Find your Account Sid and Auth Token at twilio.com/user/account
            string AccountSid = "ACb632a892c1664b3269e31d1f083cf5e0";
            string AuthToken = "AuthToken";

            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage("+19152492991", "+554188252879", "Hello World");

            if(message.RestException != null) {
                var error = message.RestException.Message;
                Console.WriteLine(error);
            }
            Console.ReadKey();
        }
    }
}
