using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacModifier.Helpers {
    public class MacExtractor {
        public static string GetMac(string response) {
            string[] mac = response.Split(':');
            string[] macs = mac[6].Split('\r');
            UInt32 currInput = Conversions.Input2Binary(macs[0].ToString());
            string last = Conversions.Binary2Output(macs[0].ToString(), currInput - 1);
            return (mac[1] + ":" + mac[2] + ":" + mac[3] + ":" + mac[4] + ":" + mac[5] + ":" + last).Trim(Response.CHARS);
        }
    }
}
