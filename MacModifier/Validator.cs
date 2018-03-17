using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacModifier {
   public class Validator {

        public bool IsValidChar(int c) {
            if(c >= 65 && c <= 70) return true;
            if(c >= 97 && c <= 102) return true;
            if(c >= 48 && c <= 58) return true;
            if(c == 8) return true;

            return false;
        }

        public bool IsValidChar(char c) {
            if(c >= 'a' && c <= 'f') return true;
            if(c >= 'A' && c <= 'F') return true;
            if(c >= '1' && c <= ':') return true;
            // if (c >= 'space') ;
            return false;
        }
    }
}