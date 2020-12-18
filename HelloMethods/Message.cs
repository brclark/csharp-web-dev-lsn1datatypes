using System;

namespace HelloMethods
{
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("tr"))
            {
                return "Merhaba dunya";
            }
            else if (lang.Equals("rs"))
            {
                return "привет мир";
            }
            else if (lang.Equals("du"))
            {
                return "Hallo wereld";
            }
            else if (lang.Equals("de"))
            {
                return "Halo welt";
            }
            else
            {
                return "Hello World";
            }
        }


        public static string GetMessageSwitch(string lang)
        {
            string message;

            switch (lang)
            {
                case "sp":
                    message = "Hola Mundo";
                    break;
                case "fr":
                    message = "Bonjour le monde";
                    break;
                case "tr":
                    message = "Merhaba dunya";
                    break;
                case "rs":
                    message = "привет мир";
                    break;
                case "du":
                    message = "Hallo wereld";
                    break;
                case "de":
                    message = "Halo welt";
                    break;
                default:
                    message = "Hello World";
                    break;
            }

            return message;
        }

    }
}
