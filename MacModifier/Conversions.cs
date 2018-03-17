﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacModifier
{
    class Conversions
    {
        public static UInt32 Input2Binary(string txtObject)
        {
            UInt64 currInput = 0;
            currInput = Convert.ToUInt64(txtObject, 16);
            if (currInput > UInt32.MaxValue)
            {
                throw new System.OverflowException("Value is too large. Please revise!");
            }

            return (UInt32)currInput;
        }

        public static string Binary2Output(string txtObject, UInt32 currVal)
        {
            txtObject = Convert.ToString(currVal, 16).ToUpper();
            if (txtObject == String.Empty)
            {
                throw new System.NullReferenceException();
            }

            return txtObject;
        }
    }
}
