namespace _06.Ext_Notifications
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var successOrError = Console.ReadLine();
                if (successOrError == "success")
                {
                    string sOperation = Console.ReadLine();
                    string sMessage = Console.ReadLine();
                    string success = ShowSuccess(sOperation, sMessage);
                    Console.WriteLine(success);
                }
                else if (successOrError == "error")
                {
                    string eOperation = Console.ReadLine();
                    var eCode = int.Parse(Console.ReadLine());
                    string error = ShowError(eOperation, eCode);
                    Console.WriteLine(error);
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\n==============================\nMessage: {message}. ";
        }

        static string ShowError(string operation, int code)
        {

            if (code > 0)
            {
                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
            }
            else
            {
                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
            }
        }
    }
}
