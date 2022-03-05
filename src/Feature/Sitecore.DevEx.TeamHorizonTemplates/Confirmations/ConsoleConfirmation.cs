using System;
using System.Globalization;

namespace Sitecore.DevEx.TeamHorizonTemplates.Confirmations
{
    internal class ConsoleConfirmation : IConfirmation
    {
        public ConfirmationResult YesNoMessage(
          string message,
          string yesMessage = null,
          string noMessage = null)
        {
            Console.WriteLine(message);
            Console.Write("\t");
            Console.WriteLine(string.Format((IFormatProvider)CultureInfo.InvariantCulture, "[{0}] - Yes", (object)"Y|y"));
            Console.Write("\t");
            Console.WriteLine(string.Format((IFormatProvider)CultureInfo.InvariantCulture, "[{0}] - No", (object)"N|n"));
            ConfirmationResult confirmationResult = ConfirmationResult.No;
            string str = Console.ReadLine();
            if (!(str == "Y") && !(str == "y"))
            {
                if (str == "N" || str == "n")
                {
                    if (noMessage != null)
                        Console.WriteLine(noMessage);
                }
                else
                    Console.WriteLine("Invalid confirmation response.");
            }
            else
            {
                if (yesMessage != null)
                    Console.WriteLine(yesMessage);
                confirmationResult = ConfirmationResult.Yes;
            }
            return confirmationResult;
        }
    }
}
