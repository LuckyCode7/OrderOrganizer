using System;
using System.Globalization;
using System.Linq;

namespace OrderOrganizer
{
    public static class OrderValidator
    {
        public static bool TrySetClientID(string clientId, out string output)
        {
            if (!String.IsNullOrEmpty(clientId) && clientId.Length > 0 && clientId.Length < 7)
            {
                foreach (var letter in clientId)
                {
                    if (!Char.IsLetterOrDigit(letter))
                    {
                        output = "";
                        return false;
                    }
                }
            }
            else
            {
                output = "";
                return false;
            }
            output = clientId;
            return true;
        }

        public static bool TrySetRequestID(string requestID, out long output)
        {
            bool status =  long.TryParse(requestID, out output);
            if (status && output >= 0)
                return true;
            else return false;
        }

        public static bool TrySetName(string name, out string output)
        {
            if (!String.IsNullOrEmpty(name) && name.Length <= 255)
            {
                int spaceCounter = 0;
                foreach (var letter in name)
                {
                    if (!Char.IsLetterOrDigit(letter))
                    {
                        if (!Char.IsWhiteSpace(letter))
                        {
                            output = "";
                            return false;
                        }
                        else spaceCounter++;
                    }
                }
                if (spaceCounter == name.Length)
                {
                    output = "";
                    return false;
                }
            }
            else
            {
                output = "";
                return false;
            }
            output = name;
            return true;
        }

        public static bool TrySetQuantityID(string quantityID, out int output)
        {
            bool status =  int.TryParse(quantityID, out output);
            if (status && output >= 0)
                return true;
            else return false;
        }

        public static bool TrySetPrice(string quantityID, out double output)
        {
            if (String.IsNullOrEmpty(quantityID) || quantityID.Substring(quantityID.LastIndexOf('.') + 1).Count() != 2)
            {
                output = 0.00;
                return false;
            }
            else
            {
                bool flag =  double.TryParse(quantityID, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out output);
                if (flag && output >= 0.00)
                    return true;
                else return false;
            }
        }
    }
}
